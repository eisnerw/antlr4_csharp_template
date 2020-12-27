import sys
import os
import requests
import shutil
import argparse
import subprocess


ANTLR_BINARY_COMPLETE_URL       = r'https://www.antlr.org/download/antlr-4.9-complete.jar'
ANTLR_BINARY_FILENAME           = r'antlr-4.9-complete.jar'
JAVA_DOWNLOAD_URL               = r'https://java.com/en/download/'


class JavaNotFound(Exception):
    def __init__(self):
        super().__init__(f"Java not found. Make sure java is in your PATH variable or download it from '{JAVA_DOWNLOAD_URL}' if necessary")


def download_antlr_binary():
    print(f'Downloading {ANTLR_BINARY_COMPLETE_URL}...', end='')
    with requests.get(ANTLR_BINARY_COMPLETE_URL) as request, open(ANTLR_BINARY_FILENAME, 'wb') as binary_file:
        binary_file.write(request.content)
    print('Done')


def get_java_path():
    path = shutil.which('java')
    if path is None:
        raise JavaNotFound
    return path


def format_antlr_command_string(java_path, args):
    #return f'"{java_path}" -jar {ANTLR_BINARY_FILENAME} -Werror -Dlanguage={args.target} -visitor -listener -o {args.output_dir} {args.grammar}'
    return f'"{java_path}" -jar {ANTLR_BINARY_FILENAME} -Dlanguage={args.target} -visitor -o {args.output_dir} {args.grammar}'


def run_antlr(args):
    if not os.path.isfile(ANTLR_BINARY_FILENAME):
        download_antlr_binary()

    java = get_java_path()

    cmd = format_antlr_command_string(java, args)

    subprocess.run(cmd, shell=True)


def parse_arguments():
    parser = argparse.ArgumentParser(description='Generating parser with antlr4')

    parser.add_argument('grammar', help='path to .g4 file with grammar')
    parser.add_argument('-o', '--output-dir', help='output directory for grammar parser', default='generated')
    parser.add_argument('-t', '--target', help='target language of parser', default='CSharp')

    return parser.parse_args()


def main():
    try:
        args = parse_arguments()
        run_antlr(args)
        return 0
    except KeyboardInterrupt:
        print()
        print("Ctrl-C")
        return 1


if __name__ == '__main__':
    exit(main())
