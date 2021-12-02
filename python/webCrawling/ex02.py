import urllib.request
import requests
from bs4 import BeautifulSoup

url = 'https://movie.naver.com/movie/bi/mi/basic.nhn?code=36944'

# html = urllib.request.urlopen(url).read()
# # print(html)
# html = BeautifulSoup(html, 'html.parser')
# print(html)

req = requests.get(url)
html = BeautifulSoup(req.text, 'html.parser')
# print(html)

review_list = []
