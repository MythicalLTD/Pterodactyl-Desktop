import re 
sometext= "test"
ansi_escape = re.compile(r'\x1B(?:[@-Z\\-_]|\[[0-?]*[ -/]*[@-~])')
result = ansi_escape.sub('', sometext)
print(result)
