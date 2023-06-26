import requests
response = requests.get('https://www.formula1.com/en/racing/2023/Saudi_arabia/Circuit.html')
if response.status_code == 200:
    print('Web site exists')
else:
    print('Web site does not exist')