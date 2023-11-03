import requests
from bs4 import BeautifulSoup

# self.seslendirme("hangi şehrin hava durumunu istersiniz")

def weatherfonk(cevap):

    url = "https://www.ntv.com.tr/{}-hava-durumu".format(cevap[0])
    request = requests.get(url)

    htlm_icerigi = request.content
    soup = BeautifulSoup(htlm_icerigi, "html.parser")

    gunduz_sicaklikları = soup.find_all("p", {"class": "hava-durumu--detail-data-item-bottom-temp-max"})
    gece_sicakliklari = soup.find_all("p", {"class": "hava-durumu--detail-data-item-bottom-temp-min"})
    hava_durumu = soup.find_all("div", {"class": "container hava-durumu--detail-data-item-bottom-desc"})
    gun_isimleri = soup.find_all("div", {"class": "daily-report-tab-content-pane-item-date"})

    gunduz = []
    gece = []
    hava = []
    for x in gunduz_sicaklikları:
        x = x.text
        gunduz.append(x)

    for y in gece_sicakliklari:
        y = y.text
        gece.append(y)

    for z in hava_durumu:
        z = z.text
        hava.append(z)

    birlestirme = "{} için yarinki hava raporları şöyle {} gündüz sıcaklığı {} gece sıcaklığı {}".format(cevap[0], hava[0],
                                                                                                         gunduz[0], gece[0])
    return birlestirme

