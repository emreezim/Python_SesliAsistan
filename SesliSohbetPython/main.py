import requests
from bs4 import BeautifulSoup

url="https://www.ntv.com.tr/denizli-hava-durumu"
request=requests.get(url)

htlm_icerigi=request.content
soup=BeautifulSoup(htlm_icerigi,"html.parser")

gunduz_sicaklikları=soup.find_all("p",{"class":"hava-durumu--detail-data-item-bottom-temp-max"})
gece_sicakliklari=soup.find_all("p",{"class":"hava-durumu--detail-data-item-bottom-temp-min"})
hava_durumu=soup.find_all("div",{"class":"container hava-durumu--detail-data-item-bottom-desc"})

gunduz=[]
gece=[]
hava=[]

for x in gunduz_sicaklikları:
    x=x.text

    gunduz.append(x)

for y in gece_sicakliklari:
    y=y.text
    gece.append(y)

for z in hava_durumu:
    z=z.text
    hava.append(z)

