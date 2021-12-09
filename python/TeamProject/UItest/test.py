from bs4 import BeautifulSoup
import requests

research = input('입력하세요 : ')
url = "https://www.coupang.com/np/search?component=&q=" + research + "&channel=user"

headers = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36"}
res = requests.get(url, headers=headers)
res.raise_for_status()
soup = BeautifulSoup(res.text, "lxml")

data1 = soup.find_all("img", attrs={"class": "search-product-wrap-img"})[0]
print(data1)

img_src = "http:" + data1.get('src')
print(img_src)
