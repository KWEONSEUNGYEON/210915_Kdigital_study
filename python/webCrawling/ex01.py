import requests
from bs4 import BeautifulSoup

req = requests.get('http://www.dowellcomputer.com/main.jsp')

# print(req)
# print(req.text)

html = BeautifulSoup(req.text, 'html.parser')
links = html.select('td > a')

# print(links)
# print(len(links))

for a in links:
    # print(a)
    if a.has_attr('href'):
        # print(a.text)
        if a.get('href').find('notice') != -1:
            print(a.text)