import requests

header = {

"Authorization": 'key' }

res = requests.post("url",headers=header)
print(res.text)