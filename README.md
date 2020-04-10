# 云可扩展OCR活动包

![海报](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/images/poster.png)

云可扩展OCR活动包采用全新的架构，为扩展而生，最大限度重用代码，让使用云OCR的活动包可以轻松创建出来。云可扩展OCR活动包可以看作[百度OCR活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)和[合合OCR活动包](https://github.com/allenlooplee/CcintOcrActivitiesPack)的一个自然演变结果，它让多套OCR活动包共享一套OCR活动（如BankCardActivity）成为可能，为未来加入其他OCR服务打下基础，同时让现有流程更换OCR服务变得容易。

## OCR活动

本活动包支持以下16个文字识别活动，用于常见的票据、卡证和汽车场景：

#|名称|类型|活动
---|---|---|---
1|增值税发票识别|票据|[VatInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VatInvoiceActivity.cs)
2|银行卡识别|卡证|[BankCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BankCardActivity.cs)
3|营业执照识别|卡证|[BusinessLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BusinessLicenseActivity.cs)
4|身份证识别|卡证|[IdCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/IdCardActivity.cs)
5|出租车票识别|票据|[TaxiReceiptActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaxiReceiptActivity.cs)
6|火车票识别|票据|[TrainTicketActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TrainTicketActivity.cs)
7|定额发票识别|票据|[QuotaInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/QuotaInvoiceActivity.cs)
8|户口本识别|卡证|[HouseholdRegisterActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HouseholdRegisterActivity.cs)
9|出生医学证明识别|卡证|[BirthCertificateActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BirthCertificateActivity.cs)
10|护照识别|卡证|[PassportActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/PassportActivity.cs)
11|港澳通行证识别|卡证|[HkMacauExitentrypermitActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HkMacauExitentrypermitActivity.cs)
12|台湾通行证识别|卡证|[TaiwanExitentrypermitActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaiwanExitentrypermitActivity.cs)
13|驾驶证识别|汽车场景|[DriverLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/DriverLicenseActivity.cs)
14|行驶证识别|汽车场景|[VehicleLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleLicenseActivity.cs)
15|机动车销售发票识别|汽车场景|[VehicleInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleInvoiceActivity.cs)
16|车辆合格证识别|汽车场景|[VehicleCertificateActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleCertificateActivity.cs)
