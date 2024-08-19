import requests

url = ''

form_data = {
    'FormKey': '',  
    'Name': '',
    'Email': 'zehrakarakayabm@gmail.com',
    'PhoneNumber': '',
    'GitAccount': 'https://github.com/0ZeKa0'
}


response = requests.post(url, data=form_data)

# Print the response from the server
print(f'Status Code: {response.status_code}')
print(f'Response Text: {response.text}')
