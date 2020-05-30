# 云可扩展OCR活动包

![海报](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/images/poster.png)

云可扩展OCR活动包采用全新的架构，为扩展而生，最大限度重用代码，让使用云OCR的活动包可以轻松创建出来。云可扩展OCR活动包可以看作[百度OCR活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)和[合合OCR活动包](https://github.com/allenlooplee/CcintOcrActivitiesPack)的一个自然演变结果，它让多套OCR活动包共享一套OCR活动（如BankCardActivity）成为可能，为未来加入其他OCR服务打下基础，同时让现有流程更换OCR服务变得容易。

## 架构概览

![架构](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/images/cloud-ocr-architecture.png)

## OCR活动清单

本活动包支持以下16个OCR活动，用于常见的票据、卡证和汽车场景，后续将会增加更多OCR活动。

#|名称|类型|[百度OCR活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)|[合合OCR活动包](https://github.com/allenlooplee/CcintOcrActivitiesPack)|[腾讯OCR活动包](https://github.com/allenlooplee/TencentOcrActivitiesPack)|[阿里OCR活动包](https://github.com/allenlooplee/AliOcrActivitiesPack)
---|---|---|:---:|:---:|:---:|:---:
1|[增值税发票识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VatInvoiceActivity.cs)|票据|:white_check_mark:|:white_check_mark:|:white_check_mark:|
2|[出租车票识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaxiReceiptActivity.cs)|票据|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
3|[火车票识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TrainTicketActivity.cs)|票据|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
4|[定额发票识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/QuotaInvoiceActivity.cs)|票据|:white_check_mark:||:white_check_mark:|
5|[银行卡识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BankCardActivity.cs)|卡证|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
6|[营业执照识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BusinessLicenseActivity.cs)|卡证|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
7|[身份证识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/IdCardActivity.cs)|卡证|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
8|[户口本识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HouseholdRegisterActivity.cs)|卡证|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
9|[出生医学证明识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BirthCertificateActivity.cs)|卡证|:white_check_mark:|||
10|[护照识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/PassportActivity.cs)|卡证|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
11|[港澳通行证识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HkMacauExitentrypermitActivity.cs)|卡证|:white_check_mark:||:white_check_mark:|
12|[台湾通行证识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaiwanExitentrypermitActivity.cs)|卡证|:white_check_mark:||:white_check_mark:|
13|[驾驶证识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/DriverLicenseActivity.cs)|汽车场景|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
14|[行驶证识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleLicenseActivity.cs)|汽车场景|:white_check_mark:|:white_check_mark:|:white_check_mark:|:white_check_mark:
15|[机动车销售发票识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleInvoiceActivity.cs)|汽车场景|:white_check_mark:||:white_check_mark:|
16|[车辆合格证识别](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleCertificateActivity.cs)|汽车场景|:white_check_mark:|:white_check_mark:||

## 其他代码库和参考资料
* [百度OCR活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)
* [合合OCR活动包](https://github.com/allenlooplee/CcintOcrActivitiesPack)
* [腾讯OCR活动包](https://github.com/allenlooplee/TencentOcrActivitiesPack)
* [阿里OCR活动包](https://github.com/allenlooplee/AliOcrActivitiesPack)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [How to Create Activities](https://docs.uipath.com/integrations/docs/how-to-create-activities)
* [Testing Framework for UiPath](https://connect.uipath.com/marketplace/components/uipath-testing-framework)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)
* [RPA开发与应用](https://github.com/allenlooplee/RPABook)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并不包含任何本地模型，你的票据将会发往云OCR服务商进行识别。
* 本活动包并不收取任何费用，但云OCR服务商可能根据你的使用情况收取相关费用。
