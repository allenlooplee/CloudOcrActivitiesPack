# 云可扩展OCR基本流程

![云可扩展OCR基本流程](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/images/cloud-ocr-basic-process.png)

“云可扩展OCR基本流程”是一个基于“流程图”的项目模版，针对使用“云可扩展OCR活动包”的流程进行了优化。你可以从[templates/CloudOcrBasicProcess](https://github.com/allenlooplee/CloudOcrActivitiesPack/tree/master/templates/CloudOcrBasicProcess)下载项目模版。

这个项目模板包含以下五个步骤：

## 初始化序列（Initialize）

这个步骤负责从指定配置文件加载配置信息，这些配置信息通常包含OCR服务的密钥。

## 加载图片序列（Load Image）

这个步骤负责检查并获取下一个需要处理的图片的路径，并把hasNext变量设为True。

## 流程决策（Flow Decision）

如果hasNext变量的值为True，则执行“处理图片序列”步骤；否则，执行“结束序列”步骤。

## 处理图片序列（Process Image）

这个步骤负责执行指定的OCR活动，从识别结果中提取所需信息，并对已处理的图片进行归档。这个步骤已经包含Cloud OCR Activities Pack的OCR Scope活动和Mock OCR Client活动。你只需把Mock OCR Client活动换成你想使用的OCR客户端活动，如Baidu OCR Client活动或Ccint OCR Client活动，再把Bank Card活动换成你想使用的OCR活动，并设置图片路径和结果变量就行了。

> 注意：识别结果将以[JObject](https://github.com/JamesNK/Newtonsoft.Json/blob/master/Src/Newtonsoft.Json/Linq/JObject.cs)对象返回。

## 结束序列（Finalize）

这个步骤负责整个流程的收尾工作，如发送一份处理报告。
