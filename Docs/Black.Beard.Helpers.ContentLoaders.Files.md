<a name='assembly'></a>
# Black.Beard.Helpers.ContentLoaders.Files

## Contents

- [Block](#T-Bb-MultiCsv-Block 'Bb.MultiCsv.Block')
  - [#ctor()](#M-Bb-MultiCsv-Block-#ctor 'Bb.MultiCsv.Block.#ctor')
  - [#ctor(header,line,rawContent)](#M-Bb-MultiCsv-Block-#ctor-Bb-MultiCsv-HeaderReference,System-Int32,System-String- 'Bb.MultiCsv.Block.#ctor(Bb.MultiCsv.HeaderReference,System.Int32,System.String)')
  - [ErrorMsg](#P-Bb-MultiCsv-Block-ErrorMsg 'Bb.MultiCsv.Block.ErrorMsg')
  - [ErrorOnblock](#P-Bb-MultiCsv-Block-ErrorOnblock 'Bb.MultiCsv.Block.ErrorOnblock')
  - [Line](#P-Bb-MultiCsv-Block-Line 'Bb.MultiCsv.Block.Line')
  - [Name](#P-Bb-MultiCsv-Block-Name 'Bb.MultiCsv.Block.Name')
  - [RawContent](#P-Bb-MultiCsv-Block-RawContent 'Bb.MultiCsv.Block.RawContent')
  - [Clear()](#M-Bb-MultiCsv-Block-Clear 'Bb.MultiCsv.Block.Clear')
- [CachedCsvReader](#T-Bb-Csv-CachedCsvReader 'Bb.Csv.CachedCsvReader')
  - [#ctor(reader,hasHeaders)](#M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean- 'Bb.Csv.CachedCsvReader.#ctor(System.IO.TextReader,System.Boolean)')
  - [#ctor(reader,hasHeaders,bufferSize)](#M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Int32- 'Bb.Csv.CachedCsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Int32)')
  - [#ctor(reader,hasHeaders,delimiter)](#M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char- 'Bb.Csv.CachedCsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char)')
  - [#ctor(reader,hasHeaders,delimiter,bufferSize)](#M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Int32- 'Bb.Csv.CachedCsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char,System.Int32)')
  - [#ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions)](#M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Char,System-Char,System-Char,Bb-Csv-ValueTrimmingOptions- 'Bb.Csv.CachedCsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char,System.Char,System.Char,System.Char,Bb.Csv.ValueTrimmingOptions)')
  - [#ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions,bufferSize)](#M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Char,System-Char,System-Char,Bb-Csv-ValueTrimmingOptions,System-Int32- 'Bb.Csv.CachedCsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char,System.Char,System.Char,System.Char,Bb.Csv.ValueTrimmingOptions,System.Int32)')
  - [_bindingList](#F-Bb-Csv-CachedCsvReader-_bindingList 'Bb.Csv.CachedCsvReader._bindingList')
  - [_currentRecordIndex](#F-Bb-Csv-CachedCsvReader-_currentRecordIndex 'Bb.Csv.CachedCsvReader._currentRecordIndex')
  - [_readingStream](#F-Bb-Csv-CachedCsvReader-_readingStream 'Bb.Csv.CachedCsvReader._readingStream')
  - [_records](#F-Bb-Csv-CachedCsvReader-_records 'Bb.Csv.CachedCsvReader._records')
  - [CurrentRecordIndex](#P-Bb-Csv-CachedCsvReader-CurrentRecordIndex 'Bb.Csv.CachedCsvReader.CurrentRecordIndex')
  - [EndOfStream](#P-Bb-Csv-CachedCsvReader-EndOfStream 'Bb.Csv.CachedCsvReader.EndOfStream')
  - [Item](#P-Bb-Csv-CachedCsvReader-Item-System-Int32- 'Bb.Csv.CachedCsvReader.Item(System.Int32)')
  - [MoveTo(record)](#M-Bb-Csv-CachedCsvReader-MoveTo-System-Int64- 'Bb.Csv.CachedCsvReader.MoveTo(System.Int64)')
  - [MoveToLastCachedRecord()](#M-Bb-Csv-CachedCsvReader-MoveToLastCachedRecord 'Bb.Csv.CachedCsvReader.MoveToLastCachedRecord')
  - [MoveToStart()](#M-Bb-Csv-CachedCsvReader-MoveToStart 'Bb.Csv.CachedCsvReader.MoveToStart')
  - [ReadNextRecord(onlyReadHeaders,skipToNextLine)](#M-Bb-Csv-CachedCsvReader-ReadNextRecord-System-Boolean,System-Boolean- 'Bb.Csv.CachedCsvReader.ReadNextRecord(System.Boolean,System.Boolean)')
  - [ReadToEnd()](#M-Bb-Csv-CachedCsvReader-ReadToEnd 'Bb.Csv.CachedCsvReader.ReadToEnd')
- [ColumnDefinition](#T-Bb-MultiCsv-ColumnDefinition 'Bb.MultiCsv.ColumnDefinition')
  - [#ctor(header,colunmName,index)](#M-Bb-MultiCsv-ColumnDefinition-#ctor-Bb-MultiCsv-HeaderReference,System-String,System-Int32- 'Bb.MultiCsv.ColumnDefinition.#ctor(Bb.MultiCsv.HeaderReference,System.String,System.Int32)')
  - [Name](#P-Bb-MultiCsv-ColumnDefinition-Name 'Bb.MultiCsv.ColumnDefinition.Name')
- [ContentHelperFiles](#T-Bb-ContentHelperFiles 'Bb.ContentHelperFiles')
  - [EvaluateEncoding(self)](#M-Bb-ContentHelperFiles-EvaluateEncoding-System-String- 'Bb.ContentHelperFiles.EvaluateEncoding(System.String)')
  - [EvaluateEncoding(self)](#M-Bb-ContentHelperFiles-EvaluateEncoding-System-IO-FileInfo- 'Bb.ContentHelperFiles.EvaluateEncoding(System.IO.FileInfo)')
  - [LoadFromFile(sourcePath)](#M-Bb-ContentHelperFiles-LoadFromFile-System-String[]- 'Bb.ContentHelperFiles.LoadFromFile(System.String[])')
  - [LoadFromFile(path,defaultEncoding)](#M-Bb-ContentHelperFiles-LoadFromFile-System-String,System-Text-Encoding- 'Bb.ContentHelperFiles.LoadFromFile(System.String,System.Text.Encoding)')
  - [LoadFromFile(self,defaultEncoding)](#M-Bb-ContentHelperFiles-LoadFromFile-System-IO-FileInfo,System-Text-Encoding- 'Bb.ContentHelperFiles.LoadFromFile(System.IO.FileInfo,System.Text.Encoding)')
  - [LoadFromFileAndDeserializeConfiguration(self,targetType,defaultEncoding,options)](#M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration-System-String,System-Type,System-Text-Encoding,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.LoadFromFileAndDeserializeConfiguration(System.String,System.Type,System.Text.Encoding,System.Text.Json.JsonSerializerOptions)')
  - [LoadFromFileAndDeserializeConfiguration(self,targetType,defaultEncoding,options)](#M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration-System-IO-FileInfo,System-Type,System-Text-Encoding,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.LoadFromFileAndDeserializeConfiguration(System.IO.FileInfo,System.Type,System.Text.Encoding,System.Text.Json.JsonSerializerOptions)')
  - [LoadFromFileAndDeserializeConfiguration\`\`1(self,defaultEncoding,options)](#M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration``1-System-String,System-Text-Encoding,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.LoadFromFileAndDeserializeConfiguration``1(System.String,System.Text.Encoding,System.Text.Json.JsonSerializerOptions)')
  - [LoadFromFileAndDeserializeConfiguration\`\`1(self,defaultEncoding,options)](#M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration``1-System-IO-FileInfo,System-Text-Encoding,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.LoadFromFileAndDeserializeConfiguration``1(System.IO.FileInfo,System.Text.Encoding,System.Text.Json.JsonSerializerOptions)')
  - [LoadFromFileAndDeserialize\`\`1(self,defaultEncoding,options)](#M-Bb-ContentHelperFiles-LoadFromFileAndDeserialize``1-System-IO-FileInfo,System-Text-Encoding,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.LoadFromFileAndDeserialize``1(System.IO.FileInfo,System.Text.Encoding,System.Text.Json.JsonSerializerOptions)')
  - [LoadFromFileAndDeserialize\`\`1(self,defaultEncoding,options)](#M-Bb-ContentHelperFiles-LoadFromFileAndDeserialize``1-System-String,System-Text-Encoding,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.LoadFromFileAndDeserialize``1(System.String,System.Text.Encoding,System.Text.Json.JsonSerializerOptions)')
  - [LoadJsonFromFile(self,defaultEncoding)](#M-Bb-ContentHelperFiles-LoadJsonFromFile-System-String,System-Text-Encoding- 'Bb.ContentHelperFiles.LoadJsonFromFile(System.String,System.Text.Encoding)')
  - [LoadMultiCsv(file)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-String- 'Bb.ContentHelperFiles.LoadMultiCsv(System.String)')
  - [LoadMultiCsv(file,rulePayload,initializer)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-String,System-String,System-Action{Bb-MultiCsv-FileReader}- 'Bb.ContentHelperFiles.LoadMultiCsv(System.String,System.String,System.Action{Bb.MultiCsv.FileReader})')
  - [LoadMultiCsv(file,rules)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-String,Bb-MultiCsv-IndentationRules- 'Bb.ContentHelperFiles.LoadMultiCsv(System.String,Bb.MultiCsv.IndentationRules)')
  - [LoadMultiCsv(file,rulePayload)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo,System-String- 'Bb.ContentHelperFiles.LoadMultiCsv(System.IO.FileInfo,System.String)')
  - [LoadMultiCsv(file,rulePayload,initializer)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo,System-String,System-Action{Bb-MultiCsv-FileReader}- 'Bb.ContentHelperFiles.LoadMultiCsv(System.IO.FileInfo,System.String,System.Action{Bb.MultiCsv.FileReader})')
  - [LoadMultiCsv(file)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo- 'Bb.ContentHelperFiles.LoadMultiCsv(System.IO.FileInfo)')
  - [LoadMultiCsv(file,rules,initializer)](#M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo,Bb-MultiCsv-IndentationRules,System-Action{Bb-MultiCsv-FileReader}- 'Bb.ContentHelperFiles.LoadMultiCsv(System.IO.FileInfo,Bb.MultiCsv.IndentationRules,System.Action{Bb.MultiCsv.FileReader})')
  - [LoadXmlFromFile(sourcePath,defaultEncoding)](#M-Bb-ContentHelperFiles-LoadXmlFromFile-System-String,System-Text-Encoding- 'Bb.ContentHelperFiles.LoadXmlFromFile(System.String,System.Text.Encoding)')
  - [LoadXmlFromFile(sourcePath,defaultEncoding)](#M-Bb-ContentHelperFiles-LoadXmlFromFile-System-IO-FileInfo,System-Text-Encoding- 'Bb.ContentHelperFiles.LoadXmlFromFile(System.IO.FileInfo,System.Text.Encoding)')
  - [Md5(filePath)](#M-Bb-ContentHelperFiles-Md5-System-String- 'Bb.ContentHelperFiles.Md5(System.String)')
  - [Md5(filePath)](#M-Bb-ContentHelperFiles-Md5-System-IO-FileInfo- 'Bb.ContentHelperFiles.Md5(System.IO.FileInfo)')
  - [OpenToWriteCsv(file,delimiter,quote,escape)](#M-Bb-ContentHelperFiles-OpenToWriteCsv-System-IO-FileInfo,System-String,System-String,System-String- 'Bb.ContentHelperFiles.OpenToWriteCsv(System.IO.FileInfo,System.String,System.String,System.String)')
  - [OpenToWriteCsv(file,delimiter,quote,escape)](#M-Bb-ContentHelperFiles-OpenToWriteCsv-System-String,System-String,System-String,System-String- 'Bb.ContentHelperFiles.OpenToWriteCsv(System.String,System.String,System.String,System.String)')
  - [Read(self)](#M-Bb-ContentHelperFiles-Read-System-IO-FileStream- 'Bb.ContentHelperFiles.Read(System.IO.FileStream)')
  - [ReadBigCsvToJson(filename,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadBigCsvToJson-System-String,System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadBigCsvToJson(System.String,System.Boolean,System.String,System.String,System.String)')
  - [ReadBigCsvToJson(file,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadBigCsvToJson-System-IO-FileInfo,System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadBigCsvToJson(System.IO.FileInfo,System.Boolean,System.String,System.String,System.String)')
  - [ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadCsv-System-String,System-Action{System-Data-IDataReader,System-Int32,System-Int32},System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadCsv(System.String,System.Action{System.Data.IDataReader,System.Int32,System.Int32},System.Boolean,System.String,System.String,System.String)')
  - [ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadCsv-System-IO-FileInfo,System-Action{System-Data-IDataReader,System-Int32,System-Int32},System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadCsv(System.IO.FileInfo,System.Action{System.Data.IDataReader,System.Int32,System.Int32},System.Boolean,System.String,System.String,System.String)')
  - [ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadCsv-System-String,System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadCsv(System.String,System.Boolean,System.String,System.String,System.String)')
  - [ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadCsv-System-IO-FileInfo,System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadCsv(System.IO.FileInfo,System.Boolean,System.String,System.String,System.String)')
  - [ReadCsvToJson(filename,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadCsvToJson-System-String,System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadCsvToJson(System.String,System.Boolean,System.String,System.String,System.String)')
  - [ReadCsvToJson(file,hasHeader,charsetSeparator,quoteCharset,escapeCharset)](#M-Bb-ContentHelperFiles-ReadCsvToJson-System-IO-FileInfo,System-Boolean,System-String,System-String,System-String- 'Bb.ContentHelperFiles.ReadCsvToJson(System.IO.FileInfo,System.Boolean,System.String,System.String,System.String)')
  - [Save(path,content,encoding)](#M-Bb-ContentHelperFiles-Save-System-String,System-String,System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.String,System.String,System.Text.Encoding)')
  - [Save(path,content,encoding)](#M-Bb-ContentHelperFiles-Save-System-IO-FileInfo,System-String,System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.IO.FileInfo,System.String,System.Text.Encoding)')
  - [Save(path,content,encoding)](#M-Bb-ContentHelperFiles-Save-System-String,System-Text-StringBuilder,System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.String,System.Text.StringBuilder,System.Text.Encoding)')
  - [Save(path,content,encoding)](#M-Bb-ContentHelperFiles-Save-System-IO-FileInfo,System-Text-StringBuilder,System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.IO.FileInfo,System.Text.StringBuilder,System.Text.Encoding)')
  - [Save(filename,payload,encoding)](#M-Bb-ContentHelperFiles-Save-System-String,System-Func{System-String},System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.String,System.Func{System.String},System.Text.Encoding)')
  - [Save(file,payload,encoding)](#M-Bb-ContentHelperFiles-Save-System-IO-FileInfo,System-Func{System-String},System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.IO.FileInfo,System.Func{System.String},System.Text.Encoding)')
  - [Save(filename,document,indented,encoding)](#M-Bb-ContentHelperFiles-Save-System-String,System-Text-Json-JsonDocument,System-Boolean,System-Text-Encoding- 'Bb.ContentHelperFiles.Save(System.String,System.Text.Json.JsonDocument,System.Boolean,System.Text.Encoding)')
  - [SerializeAndSaveConfiguration(filename,instance,sourceType)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-String,System-Object,System-Type- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration(System.String,System.Object,System.Type)')
  - [SerializeAndSaveConfiguration(filename,instance,sourceType,options)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-String,System-Object,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration(System.String,System.Object,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [SerializeAndSaveConfiguration(file,instance,targetType)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-IO-FileInfo,System-Object,System-Type- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration(System.IO.FileInfo,System.Object,System.Type)')
  - [SerializeAndSaveConfiguration(file,instance,targetType,options)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-IO-FileInfo,System-Object,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration(System.IO.FileInfo,System.Object,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [SerializeAndSaveConfiguration\`\`1(filename,instance,options)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration``1-System-String,``0,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration``1(System.String,``0,System.Text.Json.JsonSerializerOptions)')
  - [SerializeAndSaveConfiguration\`\`1(file,instance)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration``1-System-IO-FileInfo,``0- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration``1(System.IO.FileInfo,``0)')
  - [SerializeAndSaveConfiguration\`\`1(file,instance,options)](#M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration``1-System-IO-FileInfo,``0,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelperFiles.SerializeAndSaveConfiguration``1(System.IO.FileInfo,``0,System.Text.Json.JsonSerializerOptions)')
  - [SerializesAndSave(filename,instance,indented,encoding)](#M-Bb-ContentHelperFiles-SerializesAndSave-System-String,System-Object,System-Boolean,System-Text-Encoding- 'Bb.ContentHelperFiles.SerializesAndSave(System.String,System.Object,System.Boolean,System.Text.Encoding)')
  - [SerializesAndSave(file,instance,indented,encoding)](#M-Bb-ContentHelperFiles-SerializesAndSave-System-IO-FileInfo,System-Object,System-Boolean,System-Text-Encoding- 'Bb.ContentHelperFiles.SerializesAndSave(System.IO.FileInfo,System.Object,System.Boolean,System.Text.Encoding)')
  - [Sha256(filePath)](#M-Bb-ContentHelperFiles-Sha256-System-String- 'Bb.ContentHelperFiles.Sha256(System.String)')
  - [Sha256(filePath)](#M-Bb-ContentHelperFiles-Sha256-System-IO-FileInfo- 'Bb.ContentHelperFiles.Sha256(System.IO.FileInfo)')
  - [Sha512(filePath)](#M-Bb-ContentHelperFiles-Sha512-System-String- 'Bb.ContentHelperFiles.Sha512(System.String)')
  - [Sha512(filePath)](#M-Bb-ContentHelperFiles-Sha512-System-IO-FileInfo- 'Bb.ContentHelperFiles.Sha512(System.IO.FileInfo)')
  - [StreamFromFile(self)](#M-Bb-ContentHelperFiles-StreamFromFile-System-IO-FileInfo- 'Bb.ContentHelperFiles.StreamFromFile(System.IO.FileInfo)')
  - [StreamFromFile(self,encoding)](#M-Bb-ContentHelperFiles-StreamFromFile-System-IO-FileInfo,System-Text-Encoding@- 'Bb.ContentHelperFiles.StreamFromFile(System.IO.FileInfo,System.Text.Encoding@)')
- [CsvBindingList](#T-Bb-Csv-CachedCsvReader-CsvBindingList 'Bb.Csv.CachedCsvReader.CsvBindingList')
  - [#ctor(csv)](#M-Bb-Csv-CachedCsvReader-CsvBindingList-#ctor-Bb-Csv-CachedCsvReader- 'Bb.Csv.CachedCsvReader.CsvBindingList.#ctor(Bb.Csv.CachedCsvReader)')
  - [_count](#F-Bb-Csv-CachedCsvReader-CsvBindingList-_count 'Bb.Csv.CachedCsvReader.CsvBindingList._count')
  - [_csv](#F-Bb-Csv-CachedCsvReader-CsvBindingList-_csv 'Bb.Csv.CachedCsvReader.CsvBindingList._csv')
  - [_direction](#F-Bb-Csv-CachedCsvReader-CsvBindingList-_direction 'Bb.Csv.CachedCsvReader.CsvBindingList._direction')
  - [_properties](#F-Bb-Csv-CachedCsvReader-CsvBindingList-_properties 'Bb.Csv.CachedCsvReader.CsvBindingList._properties')
  - [_sort](#F-Bb-Csv-CachedCsvReader-CsvBindingList-_sort 'Bb.Csv.CachedCsvReader.CsvBindingList._sort')
- [CsvExtension](#T-Bb-Csv-CsvExtension 'Bb.Csv.CsvExtension')
  - [ReaderCsv(self,hasHeaders,delimiter,quote)](#M-Bb-Csv-CsvExtension-ReaderCsv-System-IO-FileInfo,System-Boolean,System-Char,System-Char- 'Bb.Csv.CsvExtension.ReaderCsv(System.IO.FileInfo,System.Boolean,System.Char,System.Char)')
- [CsvPropertyDescriptor](#T-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor 'Bb.Csv.CachedCsvReader.CsvPropertyDescriptor')
  - [#ctor(fieldName,index)](#M-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor-#ctor-System-String,System-Int32- 'Bb.Csv.CachedCsvReader.CsvPropertyDescriptor.#ctor(System.String,System.Int32)')
  - [_index](#F-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor-_index 'Bb.Csv.CachedCsvReader.CsvPropertyDescriptor._index')
  - [Index](#P-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor-Index 'Bb.Csv.CachedCsvReader.CsvPropertyDescriptor.Index')
- [CsvReader](#T-Bb-Csv-CsvReader 'Bb.Csv.CsvReader')
  - [#ctor(reader,hasHeaders)](#M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean- 'Bb.Csv.CsvReader.#ctor(System.IO.TextReader,System.Boolean)')
  - [#ctor(reader,hasHeaders,bufferSize)](#M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Int32- 'Bb.Csv.CsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Int32)')
  - [#ctor(reader,hasHeaders,delimiter)](#M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char- 'Bb.Csv.CsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char)')
  - [#ctor(reader,hasHeaders,delimiter,bufferSize)](#M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Int32- 'Bb.Csv.CsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char,System.Int32)')
  - [#ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions)](#M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Char,System-Char,System-Char,Bb-Csv-ValueTrimmingOptions- 'Bb.Csv.CsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char,System.Char,System.Char,System.Char,Bb.Csv.ValueTrimmingOptions)')
  - [#ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions,bufferSize)](#M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Nullable{System-Char},System-Char,System-Char,Bb-Csv-ValueTrimmingOptions,System-Int32- 'Bb.Csv.CsvReader.#ctor(System.IO.TextReader,System.Boolean,System.Char,System.Nullable{System.Char},System.Char,System.Char,Bb.Csv.ValueTrimmingOptions,System.Int32)')
  - [DefaultBufferSize](#F-Bb-Csv-CsvReader-DefaultBufferSize 'Bb.Csv.CsvReader.DefaultBufferSize')
  - [DefaultComment](#F-Bb-Csv-CsvReader-DefaultComment 'Bb.Csv.CsvReader.DefaultComment')
  - [DefaultDelimiter](#F-Bb-Csv-CsvReader-DefaultDelimiter 'Bb.Csv.CsvReader.DefaultDelimiter')
  - [DefaultEscape](#F-Bb-Csv-CsvReader-DefaultEscape 'Bb.Csv.CsvReader.DefaultEscape')
  - [DefaultQuote](#F-Bb-Csv-CsvReader-DefaultQuote 'Bb.Csv.CsvReader.DefaultQuote')
  - [_allocStack](#F-Bb-Csv-CsvReader-_allocStack 'Bb.Csv.CsvReader._allocStack')
  - [_buffer](#F-Bb-Csv-CsvReader-_buffer 'Bb.Csv.CsvReader._buffer')
  - [_bufferLength](#F-Bb-Csv-CsvReader-_bufferLength 'Bb.Csv.CsvReader._bufferLength')
  - [_bufferSize](#F-Bb-Csv-CsvReader-_bufferSize 'Bb.Csv.CsvReader._bufferSize')
  - [_comment](#F-Bb-Csv-CsvReader-_comment 'Bb.Csv.CsvReader._comment')
  - [_currentRecordIndex](#F-Bb-Csv-CsvReader-_currentRecordIndex 'Bb.Csv.CsvReader._currentRecordIndex')
  - [_defaultParseErrorAction](#F-Bb-Csv-CsvReader-_defaultParseErrorAction 'Bb.Csv.CsvReader._defaultParseErrorAction')
  - [_delimiter](#F-Bb-Csv-CsvReader-_delimiter 'Bb.Csv.CsvReader._delimiter')
  - [_eof](#F-Bb-Csv-CsvReader-_eof 'Bb.Csv.CsvReader._eof')
  - [_eol](#F-Bb-Csv-CsvReader-_eol 'Bb.Csv.CsvReader._eol')
  - [_escape](#F-Bb-Csv-CsvReader-_escape 'Bb.Csv.CsvReader._escape')
  - [_fieldCount](#F-Bb-Csv-CsvReader-_fieldCount 'Bb.Csv.CsvReader._fieldCount')
  - [_fieldHeaderComparer](#F-Bb-Csv-CsvReader-_fieldHeaderComparer 'Bb.Csv.CsvReader._fieldHeaderComparer')
  - [_fieldHeaderIndexes](#F-Bb-Csv-CsvReader-_fieldHeaderIndexes 'Bb.Csv.CsvReader._fieldHeaderIndexes')
  - [_fieldHeaders](#F-Bb-Csv-CsvReader-_fieldHeaders 'Bb.Csv.CsvReader._fieldHeaders')
  - [_fields](#F-Bb-Csv-CsvReader-_fields 'Bb.Csv.CsvReader._fields')
  - [_firstRecordInCache](#F-Bb-Csv-CsvReader-_firstRecordInCache 'Bb.Csv.CsvReader._firstRecordInCache')
  - [_hasHeaders](#F-Bb-Csv-CsvReader-_hasHeaders 'Bb.Csv.CsvReader._hasHeaders')
  - [_initialized](#F-Bb-Csv-CsvReader-_initialized 'Bb.Csv.CsvReader._initialized')
  - [_isDisposed](#F-Bb-Csv-CsvReader-_isDisposed 'Bb.Csv.CsvReader._isDisposed')
  - [_lock](#F-Bb-Csv-CsvReader-_lock 'Bb.Csv.CsvReader._lock')
  - [_missingFieldAction](#F-Bb-Csv-CsvReader-_missingFieldAction 'Bb.Csv.CsvReader._missingFieldAction')
  - [_missingFieldFlag](#F-Bb-Csv-CsvReader-_missingFieldFlag 'Bb.Csv.CsvReader._missingFieldFlag')
  - [_nextFieldIndex](#F-Bb-Csv-CsvReader-_nextFieldIndex 'Bb.Csv.CsvReader._nextFieldIndex')
  - [_nextFieldStart](#F-Bb-Csv-CsvReader-_nextFieldStart 'Bb.Csv.CsvReader._nextFieldStart')
  - [_parseErrorFlag](#F-Bb-Csv-CsvReader-_parseErrorFlag 'Bb.Csv.CsvReader._parseErrorFlag')
  - [_quote](#F-Bb-Csv-CsvReader-_quote 'Bb.Csv.CsvReader._quote')
  - [_reader](#F-Bb-Csv-CsvReader-_reader 'Bb.Csv.CsvReader._reader')
  - [_skipEmptyLines](#F-Bb-Csv-CsvReader-_skipEmptyLines 'Bb.Csv.CsvReader._skipEmptyLines')
  - [_supportsMultiline](#F-Bb-Csv-CsvReader-_supportsMultiline 'Bb.Csv.CsvReader._supportsMultiline')
  - [_trimmingOptions](#F-Bb-Csv-CsvReader-_trimmingOptions 'Bb.Csv.CsvReader._trimmingOptions')
  - [BufferSize](#P-Bb-Csv-CsvReader-BufferSize 'Bb.Csv.CsvReader.BufferSize')
  - [Comment](#P-Bb-Csv-CsvReader-Comment 'Bb.Csv.CsvReader.Comment')
  - [CurrentRecordIndex](#P-Bb-Csv-CsvReader-CurrentRecordIndex 'Bb.Csv.CsvReader.CurrentRecordIndex')
  - [DefaultHeaderName](#P-Bb-Csv-CsvReader-DefaultHeaderName 'Bb.Csv.CsvReader.DefaultHeaderName')
  - [DefaultParseErrorAction](#P-Bb-Csv-CsvReader-DefaultParseErrorAction 'Bb.Csv.CsvReader.DefaultParseErrorAction')
  - [Delimiter](#P-Bb-Csv-CsvReader-Delimiter 'Bb.Csv.CsvReader.Delimiter')
  - [EndOfStream](#P-Bb-Csv-CsvReader-EndOfStream 'Bb.Csv.CsvReader.EndOfStream')
  - [Escape](#P-Bb-Csv-CsvReader-Escape 'Bb.Csv.CsvReader.Escape')
  - [FieldCount](#P-Bb-Csv-CsvReader-FieldCount 'Bb.Csv.CsvReader.FieldCount')
  - [HasHeaders](#P-Bb-Csv-CsvReader-HasHeaders 'Bb.Csv.CsvReader.HasHeaders')
  - [IsDisposed](#P-Bb-Csv-CsvReader-IsDisposed 'Bb.Csv.CsvReader.IsDisposed')
  - [Item](#P-Bb-Csv-CsvReader-Item-System-Int32,System-String- 'Bb.Csv.CsvReader.Item(System.Int32,System.String)')
  - [Item](#P-Bb-Csv-CsvReader-Item-System-Int32,System-Int32- 'Bb.Csv.CsvReader.Item(System.Int32,System.Int32)')
  - [Item](#P-Bb-Csv-CsvReader-Item-System-String- 'Bb.Csv.CsvReader.Item(System.String)')
  - [Item](#P-Bb-Csv-CsvReader-Item-System-Int32- 'Bb.Csv.CsvReader.Item(System.Int32)')
  - [MissingFieldAction](#P-Bb-Csv-CsvReader-MissingFieldAction 'Bb.Csv.CsvReader.MissingFieldAction')
  - [MissingFieldFlag](#P-Bb-Csv-CsvReader-MissingFieldFlag 'Bb.Csv.CsvReader.MissingFieldFlag')
  - [ParseErrorFlag](#P-Bb-Csv-CsvReader-ParseErrorFlag 'Bb.Csv.CsvReader.ParseErrorFlag')
  - [Quote](#P-Bb-Csv-CsvReader-Quote 'Bb.Csv.CsvReader.Quote')
  - [SkipEmptyLines](#P-Bb-Csv-CsvReader-SkipEmptyLines 'Bb.Csv.CsvReader.SkipEmptyLines')
  - [SupportsMultiline](#P-Bb-Csv-CsvReader-SupportsMultiline 'Bb.Csv.CsvReader.SupportsMultiline')
  - [TrimmingOption](#P-Bb-Csv-CsvReader-TrimmingOption 'Bb.Csv.CsvReader.TrimmingOption')
  - [CheckDisposed()](#M-Bb-Csv-CsvReader-CheckDisposed 'Bb.Csv.CsvReader.CheckDisposed')
  - [CopyCurrentRecordTo(array)](#M-Bb-Csv-CsvReader-CopyCurrentRecordTo-System-String[]- 'Bb.Csv.CsvReader.CopyCurrentRecordTo(System.String[])')
  - [CopyCurrentRecordTo(array,index)](#M-Bb-Csv-CsvReader-CopyCurrentRecordTo-System-String[],System-Int32- 'Bb.Csv.CsvReader.CopyCurrentRecordTo(System.String[],System.Int32)')
  - [CopyFieldToArray(field,fieldOffset,destinationArray,destinationOffset,length)](#M-Bb-Csv-CsvReader-CopyFieldToArray-System-Int32,System-Int64,System-Array,System-Int32,System-Int32- 'Bb.Csv.CsvReader.CopyFieldToArray(System.Int32,System.Int64,System.Array,System.Int32,System.Int32)')
  - [Dispose()](#M-Bb-Csv-CsvReader-Dispose 'Bb.Csv.CsvReader.Dispose')
  - [Dispose(disposing)](#M-Bb-Csv-CsvReader-Dispose-System-Boolean- 'Bb.Csv.CsvReader.Dispose(System.Boolean)')
  - [DoSkipEmptyAndCommentedLines(pos)](#M-Bb-Csv-CsvReader-DoSkipEmptyAndCommentedLines-System-Int32@- 'Bb.Csv.CsvReader.DoSkipEmptyAndCommentedLines(System.Int32@)')
  - [EnsureInitialize()](#M-Bb-Csv-CsvReader-EnsureInitialize 'Bb.Csv.CsvReader.EnsureInitialize')
  - [Finalize()](#M-Bb-Csv-CsvReader-Finalize 'Bb.Csv.CsvReader.Finalize')
  - [GetCurrentRawData()](#M-Bb-Csv-CsvReader-GetCurrentRawData-System-Int32,System-Int32- 'Bb.Csv.CsvReader.GetCurrentRawData(System.Int32,System.Int32)')
  - [GetEnumerator()](#M-Bb-Csv-CsvReader-GetEnumerator 'Bb.Csv.CsvReader.GetEnumerator')
  - [GetFieldHeaders()](#M-Bb-Csv-CsvReader-GetFieldHeaders 'Bb.Csv.CsvReader.GetFieldHeaders')
  - [GetFieldIndex(header)](#M-Bb-Csv-CsvReader-GetFieldIndex-System-String- 'Bb.Csv.CsvReader.GetFieldIndex(System.String)')
  - [HandleMissingField(value,fieldIndex,currentPosition)](#M-Bb-Csv-CsvReader-HandleMissingField-System-String,System-Int32,System-Int32@- 'Bb.Csv.CsvReader.HandleMissingField(System.String,System.Int32,System.Int32@)')
  - [HandleParseError(error,pos)](#M-Bb-Csv-CsvReader-HandleParseError-Bb-Csv-Exceptions-MalformedCsvException,System-Int32@- 'Bb.Csv.CsvReader.HandleParseError(Bb.Csv.Exceptions.MalformedCsvException,System.Int32@)')
  - [IsNewLine(pos)](#M-Bb-Csv-CsvReader-IsNewLine-System-Int32- 'Bb.Csv.CsvReader.IsNewLine(System.Int32)')
  - [IsWhiteSpace(c)](#M-Bb-Csv-CsvReader-IsWhiteSpace-System-Char- 'Bb.Csv.CsvReader.IsWhiteSpace(System.Char)')
  - [MoveTo(record)](#M-Bb-Csv-CsvReader-MoveTo-System-Int64- 'Bb.Csv.CsvReader.MoveTo(System.Int64)')
  - [OnDisposed(e)](#M-Bb-Csv-CsvReader-OnDisposed-System-EventArgs- 'Bb.Csv.CsvReader.OnDisposed(System.EventArgs)')
  - [OnParseError(e)](#M-Bb-Csv-CsvReader-OnParseError-Bb-Csv-Events-ParseErrorEventArgs- 'Bb.Csv.CsvReader.OnParseError(Bb.Csv.Events.ParseErrorEventArgs)')
  - [ParseNewLine(pos)](#M-Bb-Csv-CsvReader-ParseNewLine-System-Int32@- 'Bb.Csv.CsvReader.ParseNewLine(System.Int32@)')
  - [ReadBuffer()](#M-Bb-Csv-CsvReader-ReadBuffer 'Bb.Csv.CsvReader.ReadBuffer')
  - [ReadField(field,initializing,discardValue)](#M-Bb-Csv-CsvReader-ReadField-System-Int32,System-Boolean,System-Boolean- 'Bb.Csv.CsvReader.ReadField(System.Int32,System.Boolean,System.Boolean)')
  - [ReadNextRecord()](#M-Bb-Csv-CsvReader-ReadNextRecord 'Bb.Csv.CsvReader.ReadNextRecord')
  - [ReadNextRecord(onlyReadHeaders,skipToNextLine)](#M-Bb-Csv-CsvReader-ReadNextRecord-System-Boolean,System-Boolean- 'Bb.Csv.CsvReader.ReadNextRecord(System.Boolean,System.Boolean)')
  - [SkipEmptyAndCommentedLines(pos)](#M-Bb-Csv-CsvReader-SkipEmptyAndCommentedLines-System-Int32@- 'Bb.Csv.CsvReader.SkipEmptyAndCommentedLines(System.Int32@)')
  - [SkipToNextLine(pos)](#M-Bb-Csv-CsvReader-SkipToNextLine-System-Int32@- 'Bb.Csv.CsvReader.SkipToNextLine(System.Int32@)')
  - [SkipWhiteSpaces(pos)](#M-Bb-Csv-CsvReader-SkipWhiteSpaces-System-Int32@- 'Bb.Csv.CsvReader.SkipWhiteSpaces(System.Int32@)')
  - [System#Collections#Generic#IEnumerable{System#String[]}#GetEnumerator()](#M-Bb-Csv-CsvReader-System#Collections#Generic#IEnumerable{System#String[]}#GetEnumerator 'Bb.Csv.CsvReader.System#Collections#Generic#IEnumerable{System#String[]}#GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Bb-Csv-CsvReader-System#Collections#IEnumerable#GetEnumerator 'Bb.Csv.CsvReader.System#Collections#IEnumerable#GetEnumerator')
  - [ValidateDataReader(validations)](#M-Bb-Csv-CsvReader-ValidateDataReader-Bb-Csv-CsvReader-DataReaderValidations- 'Bb.Csv.CsvReader.ValidateDataReader(Bb.Csv.CsvReader.DataReaderValidations)')
- [CsvRecordComparer](#T-Bb-Csv-CachedCsvReader-CsvRecordComparer 'Bb.Csv.CachedCsvReader.CsvRecordComparer')
  - [#ctor(field,direction)](#M-Bb-Csv-CachedCsvReader-CsvRecordComparer-#ctor-System-Int32,System-ComponentModel-ListSortDirection- 'Bb.Csv.CachedCsvReader.CsvRecordComparer.#ctor(System.Int32,System.ComponentModel.ListSortDirection)')
  - [_direction](#F-Bb-Csv-CachedCsvReader-CsvRecordComparer-_direction 'Bb.Csv.CachedCsvReader.CsvRecordComparer._direction')
  - [_field](#F-Bb-Csv-CachedCsvReader-CsvRecordComparer-_field 'Bb.Csv.CachedCsvReader.CsvRecordComparer._field')
- [CsvWriter](#T-Bb-Csv-CsvWriter 'Bb.Csv.CsvWriter')
  - [#ctor(delimiter,quote,escape)](#M-Bb-Csv-CsvWriter-#ctor-System-String,System-String,System-String- 'Bb.Csv.CsvWriter.#ctor(System.String,System.String,System.String)')
  - [Close()](#M-Bb-Csv-CsvWriter-Close 'Bb.Csv.CsvWriter.Close')
  - [Dispose(disposing)](#M-Bb-Csv-CsvWriter-Dispose-System-Boolean- 'Bb.Csv.CsvWriter.Dispose(System.Boolean)')
  - [Flush()](#M-Bb-Csv-CsvWriter-Flush 'Bb.Csv.CsvWriter.Flush')
  - [Open(file,encoding)](#M-Bb-Csv-CsvWriter-Open-System-String,System-Text-Encoding- 'Bb.Csv.CsvWriter.Open(System.String,System.Text.Encoding)')
  - [Open(file,encoding)](#M-Bb-Csv-CsvWriter-Open-System-IO-FileInfo,System-Text-Encoding- 'Bb.Csv.CsvWriter.Open(System.IO.FileInfo,System.Text.Encoding)')
  - [WriteHeaders(hearders)](#M-Bb-Csv-CsvWriter-WriteHeaders-System-String[]- 'Bb.Csv.CsvWriter.WriteHeaders(System.String[])')
  - [WriteLine(datas)](#M-Bb-Csv-CsvWriter-WriteLine-System-Object[]- 'Bb.Csv.CsvWriter.WriteLine(System.Object[])')
  - [WriteLines(datas)](#M-Bb-Csv-CsvWriter-WriteLines-System-Collections-Generic-IEnumerable{System-Object[]}- 'Bb.Csv.CsvWriter.WriteLines(System.Collections.Generic.IEnumerable{System.Object[]})')
- [DataReaderValidations](#T-Bb-Csv-CsvReader-DataReaderValidations 'Bb.Csv.CsvReader.DataReaderValidations')
  - [IsInitialized](#F-Bb-Csv-CsvReader-DataReaderValidations-IsInitialized 'Bb.Csv.CsvReader.DataReaderValidations.IsInitialized')
  - [IsNotClosed](#F-Bb-Csv-CsvReader-DataReaderValidations-IsNotClosed 'Bb.Csv.CsvReader.DataReaderValidations.IsNotClosed')
  - [None](#F-Bb-Csv-CsvReader-DataReaderValidations-None 'Bb.Csv.CsvReader.DataReaderValidations.None')
- [ExceptionMessage](#T-Bb-Csv-ExceptionMessage 'Bb.Csv.ExceptionMessage')
  - [BufferSizeTooSmall](#P-Bb-Csv-ExceptionMessage-BufferSizeTooSmall 'Bb.Csv.ExceptionMessage.BufferSizeTooSmall')
  - [CannotMovePreviousRecordInForwardOnly](#P-Bb-Csv-ExceptionMessage-CannotMovePreviousRecordInForwardOnly 'Bb.Csv.ExceptionMessage.CannotMovePreviousRecordInForwardOnly')
  - [CannotReadRecordAtIndex](#P-Bb-Csv-ExceptionMessage-CannotReadRecordAtIndex 'Bb.Csv.ExceptionMessage.CannotReadRecordAtIndex')
  - [Culture](#P-Bb-Csv-ExceptionMessage-Culture 'Bb.Csv.ExceptionMessage.Culture')
  - [EnumerationFinishedOrNotStarted](#P-Bb-Csv-ExceptionMessage-EnumerationFinishedOrNotStarted 'Bb.Csv.ExceptionMessage.EnumerationFinishedOrNotStarted')
  - [EnumerationVersionCheckFailed](#P-Bb-Csv-ExceptionMessage-EnumerationVersionCheckFailed 'Bb.Csv.ExceptionMessage.EnumerationVersionCheckFailed')
  - [FieldHeaderNotFound](#P-Bb-Csv-ExceptionMessage-FieldHeaderNotFound 'Bb.Csv.ExceptionMessage.FieldHeaderNotFound')
  - [FieldIndexOutOfRange](#P-Bb-Csv-ExceptionMessage-FieldIndexOutOfRange 'Bb.Csv.ExceptionMessage.FieldIndexOutOfRange')
  - [MalformedCsvException](#P-Bb-Csv-ExceptionMessage-MalformedCsvException 'Bb.Csv.ExceptionMessage.MalformedCsvException')
  - [MissingFieldActionNotSupported](#P-Bb-Csv-ExceptionMessage-MissingFieldActionNotSupported 'Bb.Csv.ExceptionMessage.MissingFieldActionNotSupported')
  - [NoCurrentRecord](#P-Bb-Csv-ExceptionMessage-NoCurrentRecord 'Bb.Csv.ExceptionMessage.NoCurrentRecord')
  - [NoHeaders](#P-Bb-Csv-ExceptionMessage-NoHeaders 'Bb.Csv.ExceptionMessage.NoHeaders')
  - [NotEnoughSpaceInArray](#P-Bb-Csv-ExceptionMessage-NotEnoughSpaceInArray 'Bb.Csv.ExceptionMessage.NotEnoughSpaceInArray')
  - [ParseErrorActionInvalidInsideParseErrorEvent](#P-Bb-Csv-ExceptionMessage-ParseErrorActionInvalidInsideParseErrorEvent 'Bb.Csv.ExceptionMessage.ParseErrorActionInvalidInsideParseErrorEvent')
  - [ParseErrorActionNotSupported](#P-Bb-Csv-ExceptionMessage-ParseErrorActionNotSupported 'Bb.Csv.ExceptionMessage.ParseErrorActionNotSupported')
  - [ReaderClosed](#P-Bb-Csv-ExceptionMessage-ReaderClosed 'Bb.Csv.ExceptionMessage.ReaderClosed')
  - [RecordIndexLessThanZero](#P-Bb-Csv-ExceptionMessage-RecordIndexLessThanZero 'Bb.Csv.ExceptionMessage.RecordIndexLessThanZero')
  - [ResourceManager](#P-Bb-Csv-ExceptionMessage-ResourceManager 'Bb.Csv.ExceptionMessage.ResourceManager')
- [FileInformations](#T-Bb-MultiCsv-FileInformations 'Bb.MultiCsv.FileInformations')
  - [#ctor()](#M-Bb-MultiCsv-FileInformations-#ctor 'Bb.MultiCsv.FileInformations.#ctor')
  - [_headers](#F-Bb-MultiCsv-FileInformations-_headers 'Bb.MultiCsv.FileInformations._headers')
  - [EncodingByUde](#P-Bb-MultiCsv-FileInformations-EncodingByUde 'Bb.MultiCsv.FileInformations.EncodingByUde')
  - [FileInfo](#P-Bb-MultiCsv-FileInformations-FileInfo 'Bb.MultiCsv.FileInformations.FileInfo')
  - [Headers](#P-Bb-MultiCsv-FileInformations-Headers 'Bb.MultiCsv.FileInformations.Headers')
  - [GetHeader(e)](#M-Bb-MultiCsv-FileInformations-GetHeader-System-String,System-String- 'Bb.MultiCsv.FileInformations.GetHeader(System.String,System.String)')
- [FileReader](#T-Bb-MultiCsv-FileReader 'Bb.MultiCsv.FileReader')
  - [FileInformations](#P-Bb-MultiCsv-FileReader-FileInformations 'Bb.MultiCsv.FileReader.FileInformations')
  - [FileReadFile(filePath,rulePayload,initializer)](#M-Bb-MultiCsv-FileReader-FileReadFile-System-String,System-String,System-Action{Bb-MultiCsv-FileReader}- 'Bb.MultiCsv.FileReader.FileReadFile(System.String,System.String,System.Action{Bb.MultiCsv.FileReader})')
  - [FileReadFile(filePath,rulePayload,initializer)](#M-Bb-MultiCsv-FileReader-FileReadFile-System-String,Bb-MultiCsv-IndentationRules,System-Action{Bb-MultiCsv-FileReader}- 'Bb.MultiCsv.FileReader.FileReadFile(System.String,Bb.MultiCsv.IndentationRules,System.Action{Bb.MultiCsv.FileReader})')
  - [See(see,filter)](#M-Bb-MultiCsv-FileReader-See-System-String,System-Func{Bb-MultiCsv-Block,System-Boolean}- 'Bb.MultiCsv.FileReader.See(System.String,System.Func{Bb.MultiCsv.Block,System.Boolean})')
- [HeaderReference](#T-Bb-MultiCsv-HeaderReference 'Bb.MultiCsv.HeaderReference')
  - [#ctor(headerName)](#M-Bb-MultiCsv-HeaderReference-#ctor-System-String,System-String- 'Bb.MultiCsv.HeaderReference.#ctor(System.String,System.String)')
  - [LabelLine](#P-Bb-MultiCsv-HeaderReference-LabelLine 'Bb.MultiCsv.HeaderReference.LabelLine')
  - [Schema](#P-Bb-MultiCsv-HeaderReference-Schema 'Bb.MultiCsv.HeaderReference.Schema')
- [IndentationRule](#T-Bb-MultiCsv-IndentationRule 'Bb.MultiCsv.IndentationRule')
  - [#ctor(rule)](#M-Bb-MultiCsv-IndentationRule-#ctor-System-String- 'Bb.MultiCsv.IndentationRule.#ctor(System.String)')
  - [Children](#P-Bb-MultiCsv-IndentationRule-Children 'Bb.MultiCsv.IndentationRule.Children')
  - [Key](#P-Bb-MultiCsv-IndentationRule-Key 'Bb.MultiCsv.IndentationRule.Key')
- [IndentationRules](#T-Bb-MultiCsv-IndentationRules 'Bb.MultiCsv.IndentationRules')
  - [#ctor(payload)](#M-Bb-MultiCsv-IndentationRules-#ctor-System-String- 'Bb.MultiCsv.IndentationRules.#ctor(System.String)')
  - [HasRule](#P-Bb-MultiCsv-IndentationRules-HasRule 'Bb.MultiCsv.IndentationRules.HasRule')
  - [Equals(obj)](#M-Bb-MultiCsv-IndentationRules-Equals-System-Object- 'Bb.MultiCsv.IndentationRules.Equals(System.Object)')
  - [EvaluateIfEmbeddedInParent(parent,child)](#M-Bb-MultiCsv-IndentationRules-EvaluateIfEmbeddedInParent-Bb-MultiCsv-Block,Bb-MultiCsv-Block- 'Bb.MultiCsv.IndentationRules.EvaluateIfEmbeddedInParent(Bb.MultiCsv.Block,Bb.MultiCsv.Block)')
- [Lexer](#T-Bb-MultiCsv-Lexer 'Bb.MultiCsv.Lexer')
  - [#ctor(file,encoding)](#M-Bb-MultiCsv-Lexer-#ctor-System-String,System-Text-Encoding- 'Bb.MultiCsv.Lexer.#ctor(System.String,System.Text.Encoding)')
  - [Current](#P-Bb-MultiCsv-Lexer-Current 'Bb.MultiCsv.Lexer.Current')
  - [Close()](#M-Bb-MultiCsv-Lexer-Close 'Bb.MultiCsv.Lexer.Close')
  - [Dispose()](#M-Bb-MultiCsv-Lexer-Dispose 'Bb.MultiCsv.Lexer.Dispose')
  - [Dispose(disposing)](#M-Bb-MultiCsv-Lexer-Dispose-System-Boolean- 'Bb.MultiCsv.Lexer.Dispose(System.Boolean)')
  - [Finalize()](#M-Bb-MultiCsv-Lexer-Finalize 'Bb.MultiCsv.Lexer.Finalize')
  - [GetLine()](#M-Bb-MultiCsv-Lexer-GetLine 'Bb.MultiCsv.Lexer.GetLine')
  - [MoveNext()](#M-Bb-MultiCsv-Lexer-MoveNext 'Bb.MultiCsv.Lexer.MoveNext')
  - [Open()](#M-Bb-MultiCsv-Lexer-Open-System-Text-Encoding- 'Bb.MultiCsv.Lexer.Open(System.Text.Encoding)')
  - [ReadDef(s)](#M-Bb-MultiCsv-Lexer-ReadDef-System-String[]- 'Bb.MultiCsv.Lexer.ReadDef(System.String[])')
  - [ReadLine()](#M-Bb-MultiCsv-Lexer-ReadLine-System-String@- 'Bb.MultiCsv.Lexer.ReadLine(System.String@)')
- [MalformedCsvException](#T-Bb-Csv-Exceptions-MalformedCsvException 'Bb.Csv.Exceptions.MalformedCsvException')
  - [#ctor()](#M-Bb-Csv-Exceptions-MalformedCsvException-#ctor 'Bb.Csv.Exceptions.MalformedCsvException.#ctor')
  - [#ctor(message)](#M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String- 'Bb.Csv.Exceptions.MalformedCsvException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String,System-Exception- 'Bb.Csv.Exceptions.MalformedCsvException.#ctor(System.String,System.Exception)')
  - [#ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex)](#M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32- 'Bb.Csv.Exceptions.MalformedCsvException.#ctor(System.String,System.Int32,System.Int64,System.Int32)')
  - [#ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex,innerException)](#M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32,System-Exception- 'Bb.Csv.Exceptions.MalformedCsvException.#ctor(System.String,System.Int32,System.Int64,System.Int32,System.Exception)')
  - [#ctor(info,context)](#M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Bb.Csv.Exceptions.MalformedCsvException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
  - [_currentFieldIndex](#F-Bb-Csv-Exceptions-MalformedCsvException-_currentFieldIndex 'Bb.Csv.Exceptions.MalformedCsvException._currentFieldIndex')
  - [_currentPosition](#F-Bb-Csv-Exceptions-MalformedCsvException-_currentPosition 'Bb.Csv.Exceptions.MalformedCsvException._currentPosition')
  - [_currentRecordIndex](#F-Bb-Csv-Exceptions-MalformedCsvException-_currentRecordIndex 'Bb.Csv.Exceptions.MalformedCsvException._currentRecordIndex')
  - [_message](#F-Bb-Csv-Exceptions-MalformedCsvException-_message 'Bb.Csv.Exceptions.MalformedCsvException._message')
  - [_rawData](#F-Bb-Csv-Exceptions-MalformedCsvException-_rawData 'Bb.Csv.Exceptions.MalformedCsvException._rawData')
  - [CurrentFieldIndex](#P-Bb-Csv-Exceptions-MalformedCsvException-CurrentFieldIndex 'Bb.Csv.Exceptions.MalformedCsvException.CurrentFieldIndex')
  - [CurrentPosition](#P-Bb-Csv-Exceptions-MalformedCsvException-CurrentPosition 'Bb.Csv.Exceptions.MalformedCsvException.CurrentPosition')
  - [CurrentRecordIndex](#P-Bb-Csv-Exceptions-MalformedCsvException-CurrentRecordIndex 'Bb.Csv.Exceptions.MalformedCsvException.CurrentRecordIndex')
  - [Message](#P-Bb-Csv-Exceptions-MalformedCsvException-Message 'Bb.Csv.Exceptions.MalformedCsvException.Message')
  - [RawData](#P-Bb-Csv-Exceptions-MalformedCsvException-RawData 'Bb.Csv.Exceptions.MalformedCsvException.RawData')
  - [GetObjectData(info,context)](#M-Bb-Csv-Exceptions-MalformedCsvException-GetObjectData-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Bb.Csv.Exceptions.MalformedCsvException.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [MissingFieldAction](#T-Bb-Csv-MissingFieldAction 'Bb.Csv.MissingFieldAction')
  - [ParseError](#F-Bb-Csv-MissingFieldAction-ParseError 'Bb.Csv.MissingFieldAction.ParseError')
  - [ReplaceByEmpty](#F-Bb-Csv-MissingFieldAction-ReplaceByEmpty 'Bb.Csv.MissingFieldAction.ReplaceByEmpty')
  - [ReplaceByNull](#F-Bb-Csv-MissingFieldAction-ReplaceByNull 'Bb.Csv.MissingFieldAction.ReplaceByNull')
- [MissingFieldCsvException](#T-Bb-Csv-Exceptions-MissingFieldCsvException 'Bb.Csv.Exceptions.MissingFieldCsvException')
  - [#ctor()](#M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor 'Bb.Csv.Exceptions.MissingFieldCsvException.#ctor')
  - [#ctor(message)](#M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String- 'Bb.Csv.Exceptions.MissingFieldCsvException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String,System-Exception- 'Bb.Csv.Exceptions.MissingFieldCsvException.#ctor(System.String,System.Exception)')
  - [#ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex)](#M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32- 'Bb.Csv.Exceptions.MissingFieldCsvException.#ctor(System.String,System.Int32,System.Int64,System.Int32)')
  - [#ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex,innerException)](#M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32,System-Exception- 'Bb.Csv.Exceptions.MissingFieldCsvException.#ctor(System.String,System.Int32,System.Int64,System.Int32,System.Exception)')
  - [#ctor(info,context)](#M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Bb.Csv.Exceptions.MissingFieldCsvException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [ParseErrorAction](#T-Bb-Csv-ParseErrorAction 'Bb.Csv.ParseErrorAction')
  - [AdvanceToNextLine](#F-Bb-Csv-ParseErrorAction-AdvanceToNextLine 'Bb.Csv.ParseErrorAction.AdvanceToNextLine')
  - [RaiseEvent](#F-Bb-Csv-ParseErrorAction-RaiseEvent 'Bb.Csv.ParseErrorAction.RaiseEvent')
  - [ThrowException](#F-Bb-Csv-ParseErrorAction-ThrowException 'Bb.Csv.ParseErrorAction.ThrowException')
- [ParseErrorEventArgs](#T-Bb-Csv-Events-ParseErrorEventArgs 'Bb.Csv.Events.ParseErrorEventArgs')
  - [#ctor(error,defaultAction)](#M-Bb-Csv-Events-ParseErrorEventArgs-#ctor-Bb-Csv-Exceptions-MalformedCsvException,Bb-Csv-ParseErrorAction- 'Bb.Csv.Events.ParseErrorEventArgs.#ctor(Bb.Csv.Exceptions.MalformedCsvException,Bb.Csv.ParseErrorAction)')
  - [_action](#F-Bb-Csv-Events-ParseErrorEventArgs-_action 'Bb.Csv.Events.ParseErrorEventArgs._action')
  - [_error](#F-Bb-Csv-Events-ParseErrorEventArgs-_error 'Bb.Csv.Events.ParseErrorEventArgs._error')
  - [Action](#P-Bb-Csv-Events-ParseErrorEventArgs-Action 'Bb.Csv.Events.ParseErrorEventArgs.Action')
  - [Error](#P-Bb-Csv-Events-ParseErrorEventArgs-Error 'Bb.Csv.Events.ParseErrorEventArgs.Error')
- [RecordEnumerator](#T-Bb-Csv-CsvReader-RecordEnumerator 'Bb.Csv.CsvReader.RecordEnumerator')
  - [#ctor(reader)](#M-Bb-Csv-CsvReader-RecordEnumerator-#ctor-Bb-Csv-CsvReader- 'Bb.Csv.CsvReader.RecordEnumerator.#ctor(Bb.Csv.CsvReader)')
  - [_current](#F-Bb-Csv-CsvReader-RecordEnumerator-_current 'Bb.Csv.CsvReader.RecordEnumerator._current')
  - [_currentRecordIndex](#F-Bb-Csv-CsvReader-RecordEnumerator-_currentRecordIndex 'Bb.Csv.CsvReader.RecordEnumerator._currentRecordIndex')
  - [_reader](#F-Bb-Csv-CsvReader-RecordEnumerator-_reader 'Bb.Csv.CsvReader.RecordEnumerator._reader')
  - [Current](#P-Bb-Csv-CsvReader-RecordEnumerator-Current 'Bb.Csv.CsvReader.RecordEnumerator.Current')
  - [System#Collections#IEnumerator#Current](#P-Bb-Csv-CsvReader-RecordEnumerator-System#Collections#IEnumerator#Current 'Bb.Csv.CsvReader.RecordEnumerator.System#Collections#IEnumerator#Current')
  - [Dispose()](#M-Bb-Csv-CsvReader-RecordEnumerator-Dispose 'Bb.Csv.CsvReader.RecordEnumerator.Dispose')
  - [MoveNext()](#M-Bb-Csv-CsvReader-RecordEnumerator-MoveNext 'Bb.Csv.CsvReader.RecordEnumerator.MoveNext')
  - [Reset()](#M-Bb-Csv-CsvReader-RecordEnumerator-Reset 'Bb.Csv.CsvReader.RecordEnumerator.Reset')
- [Token](#T-Bb-MultiCsv-Token 'Bb.MultiCsv.Token')
  - [EOF](#F-Bb-MultiCsv-Token-EOF 'Bb.MultiCsv.Token.EOF')
  - [None](#F-Bb-MultiCsv-Token-None 'Bb.MultiCsv.Token.None')
  - [UNKNOWN](#F-Bb-MultiCsv-Token-UNKNOWN 'Bb.MultiCsv.Token.UNKNOWN')
- [ValueTrimmingOptions](#T-Bb-Csv-ValueTrimmingOptions 'Bb.Csv.ValueTrimmingOptions')
  - [All](#F-Bb-Csv-ValueTrimmingOptions-All 'Bb.Csv.ValueTrimmingOptions.All')
  - [None](#F-Bb-Csv-ValueTrimmingOptions-None 'Bb.Csv.ValueTrimmingOptions.None')
  - [QuotedOnly](#F-Bb-Csv-ValueTrimmingOptions-QuotedOnly 'Bb.Csv.ValueTrimmingOptions.QuotedOnly')
  - [UnquotedOnly](#F-Bb-Csv-ValueTrimmingOptions-UnquotedOnly 'Bb.Csv.ValueTrimmingOptions.UnquotedOnly')

<a name='T-Bb-MultiCsv-Block'></a>
## Block `type`

##### Namespace

Bb.MultiCsv

##### Summary

Class block

<a name='M-Bb-MultiCsv-Block-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [Block](#T-Bb-MultiCsv-Block 'Bb.MultiCsv.Block') class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-MultiCsv-Block-#ctor-Bb-MultiCsv-HeaderReference,System-Int32,System-String-'></a>
### #ctor(header,line,rawContent) `constructor`

##### Summary

Initializes a new instance of the [Block](#T-Bb-MultiCsv-Block 'Bb.MultiCsv.Block') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [Bb.MultiCsv.HeaderReference](#T-Bb-MultiCsv-HeaderReference 'Bb.MultiCsv.HeaderReference') | The header. |
| line | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The line. |
| rawContent | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Content of the raw. |

<a name='P-Bb-MultiCsv-Block-ErrorMsg'></a>
### ErrorMsg `property`

##### Summary

Gets or sets the error message

<a name='P-Bb-MultiCsv-Block-ErrorOnblock'></a>
### ErrorOnblock `property`

##### Summary

Gets or sets the error status of the row

<a name='P-Bb-MultiCsv-Block-Line'></a>
### Line `property`

##### Summary

Gets or sets the line.

<a name='P-Bb-MultiCsv-Block-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='P-Bb-MultiCsv-Block-RawContent'></a>
### RawContent `property`

##### Summary

Gets or sets the content of the raw.

<a name='M-Bb-MultiCsv-Block-Clear'></a>
### Clear() `method`

##### Summary

Clear the dictionary and the value of the Block

##### Parameters

This method has no parameters.

<a name='T-Bb-Csv-CachedCsvReader'></a>
## CachedCsvReader `type`

##### Namespace

Bb.Csv

##### Summary

Represents a reader that provides fast, cached, dynamic access to CSV data.

##### Remarks

The number of records is limited to [MaxValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32.MaxValue 'System.Int32.MaxValue') - 1.

<a name='M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean-'></a>
### #ctor(reader,hasHeaders) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Int32-'></a>
### #ctor(reader,hasHeaders,bufferSize) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The buffer size in bytes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char-'></a>
### #ctor(reader,hasHeaders,delimiter) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Int32-'></a>
### #ctor(reader,hasHeaders,delimiter,bufferSize) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The buffer size in bytes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Char,System-Char,System-Char,Bb-Csv-ValueTrimmingOptions-'></a>
### #ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |
| quote | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The quotation character wrapping every field (default is '''). |
| escape | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The escape character letting insert quotation characters inside a quoted field (default is '\').
If no escape character, set to '\0' to gain some performance. |
| comment | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The comment character indicating that a line is commented out (default is '#'). |
| trimmingOptions | [Bb.Csv.ValueTrimmingOptions](#T-Bb-Csv-ValueTrimmingOptions 'Bb.Csv.ValueTrimmingOptions') | Determines how values should be trimmed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CachedCsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Char,System-Char,System-Char,Bb-Csv-ValueTrimmingOptions,System-Int32-'></a>
### #ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions,bufferSize) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |
| quote | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The quotation character wrapping every field (default is '''). |
| escape | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The escape character letting insert quotation characters inside a quoted field (default is '\').
If no escape character, set to '\0' to gain some performance. |
| comment | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The comment character indicating that a line is commented out (default is '#'). |
| trimmingOptions | [Bb.Csv.ValueTrimmingOptions](#T-Bb-Csv-ValueTrimmingOptions 'Bb.Csv.ValueTrimmingOptions') | `true` if spaces at the start and end of a field are trimmed, otherwise, `false`. Default is `true`. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The buffer size in bytes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `bufferSize` must be 1 or more. |

<a name='F-Bb-Csv-CachedCsvReader-_bindingList'></a>
### _bindingList `constants`

##### Summary

Contains the binding list linked to this reader.

<a name='F-Bb-Csv-CachedCsvReader-_currentRecordIndex'></a>
### _currentRecordIndex `constants`

##### Summary

Contains the current record index (inside the cached records array).

<a name='F-Bb-Csv-CachedCsvReader-_readingStream'></a>
### _readingStream `constants`

##### Summary

Indicates if a new record is being read from the CSV stream.

<a name='F-Bb-Csv-CachedCsvReader-_records'></a>
### _records `constants`

##### Summary

Contains the cached records.

<a name='P-Bb-Csv-CachedCsvReader-CurrentRecordIndex'></a>
### CurrentRecordIndex `property`

##### Summary

Gets the current record index in the CSV file.

<a name='P-Bb-Csv-CachedCsvReader-EndOfStream'></a>
### EndOfStream `property`

##### Summary

Gets a value that indicates whether the current stream position is at the end of the stream.

<a name='P-Bb-Csv-CachedCsvReader-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets the field at the specified index.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentOutOfRangeException](#T-ArgumentOutOfRangeException 'ArgumentOutOfRangeException') | `field` must be included in [0, [FieldCount](#M-FieldCount 'FieldCount')[. |
| [InvalidOperationException](#T-InvalidOperationException 'InvalidOperationException') | No record read yet. Call ReadLine() first. |
| [MalformedCsvException](#T-MalformedCsvException 'MalformedCsvException') | The CSV appears to be corrupt at the current position. |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CachedCsvReader-MoveTo-System-Int64-'></a>
### MoveTo(record) `method`

##### Summary

Moves to the specified record index.

##### Returns

`true` if the operation was successful; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The record index. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CachedCsvReader-MoveToLastCachedRecord'></a>
### MoveToLastCachedRecord() `method`

##### Summary

Moves to the last record read so far.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CachedCsvReader-MoveToStart'></a>
### MoveToStart() `method`

##### Summary

Moves before the first record.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CachedCsvReader-ReadNextRecord-System-Boolean,System-Boolean-'></a>
### ReadNextRecord(onlyReadHeaders,skipToNextLine) `method`

##### Summary

Reads the next record.

##### Returns

`true` if a record has been successfully reads; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyReadHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates if the reader will proceed to the next record after having read headers.
`true` if it stops after having read headers; otherwise, `false`. |
| skipToNextLine | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates if the reader will skip directly to the next line without parsing the current one. 
To be used when an error occurs. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CachedCsvReader-ReadToEnd'></a>
### ReadToEnd() `method`

##### Summary

Reads the CSV stream from the current position to the end of the stream.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='T-Bb-MultiCsv-ColumnDefinition'></a>
## ColumnDefinition `type`

##### Namespace

Bb.MultiCsv

##### Summary

Class ColumnDefinition

<a name='M-Bb-MultiCsv-ColumnDefinition-#ctor-Bb-MultiCsv-HeaderReference,System-String,System-Int32-'></a>
### #ctor(header,colunmName,index) `constructor`

##### Summary

Initializes a new instance of the [ColumnDefinition](#T-Bb-MultiCsv-ColumnDefinition 'Bb.MultiCsv.ColumnDefinition') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [Bb.MultiCsv.HeaderReference](#T-Bb-MultiCsv-HeaderReference 'Bb.MultiCsv.HeaderReference') | The header. |
| colunmName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the colunm. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index. |

<a name='P-Bb-MultiCsv-ColumnDefinition-Name'></a>
### Name `property`

##### Summary

Gets the name.

<a name='T-Bb-ContentHelperFiles'></a>
## ContentHelperFiles `type`

##### Namespace

Bb

##### Summary

Content helper for managing files

<a name='M-Bb-ContentHelperFiles-EvaluateEncoding-System-String-'></a>
### EvaluateEncoding(self) `method`

##### Summary

evaluate encoding of the file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | [FileInfo](#T-FileInfo 'FileInfo') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-EvaluateEncoding-System-IO-FileInfo-'></a>
### EvaluateEncoding(self) `method`

##### Summary

evaluate encoding of the file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFile-System-String[]-'></a>
### LoadFromFile(sourcePath) `method`

##### Summary

Loads the content of the file.

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The source path segment. the path is concatenated with Path.Combine |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.InvalidDataException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.InvalidDataException 'System.IO.InvalidDataException') | if the sourcePath do not contains path |

<a name='M-Bb-ContentHelperFiles-LoadFromFile-System-String,System-Text-Encoding-'></a>
### LoadFromFile(path,defaultEncoding) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFile-System-IO-FileInfo,System-Text-Encoding-'></a>
### LoadFromFile(self,defaultEncoding) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration-System-String,System-Type,System-Text-Encoding,System-Text-Json-JsonSerializerOptions-'></a>
### LoadFromFileAndDeserializeConfiguration(self,targetType,defaultEncoding,options) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | target type |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration-System-IO-FileInfo,System-Type,System-Text-Encoding,System-Text-Json-JsonSerializerOptions-'></a>
### LoadFromFileAndDeserializeConfiguration(self,targetType,defaultEncoding,options) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | target type |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration``1-System-String,System-Text-Encoding,System-Text-Json-JsonSerializerOptions-'></a>
### LoadFromFileAndDeserializeConfiguration\`\`1(self,defaultEncoding,options) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TargetType | The type of the target type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFileAndDeserializeConfiguration``1-System-IO-FileInfo,System-Text-Encoding,System-Text-Json-JsonSerializerOptions-'></a>
### LoadFromFileAndDeserializeConfiguration\`\`1(self,defaultEncoding,options) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TargetType | The type of the target type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFileAndDeserialize``1-System-IO-FileInfo,System-Text-Encoding,System-Text-Json-JsonSerializerOptions-'></a>
### LoadFromFileAndDeserialize\`\`1(self,defaultEncoding,options) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TargetType | The type of the target type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadFromFileAndDeserialize``1-System-String,System-Text-Encoding,System-Text-Json-JsonSerializerOptions-'></a>
### LoadFromFileAndDeserialize\`\`1(self,defaultEncoding,options) `method`

##### Summary

Load the content from file

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | [FileInfo](#T-FileInfo 'FileInfo') |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TargetType | The type of the target type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadJsonFromFile-System-String,System-Text-Encoding-'></a>
### LoadJsonFromFile(self,defaultEncoding) `method`

##### Summary

Load the content json from file

##### Returns

the json document [JsonDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonDocument 'System.Text.Json.JsonDocument') of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-String-'></a>
### LoadMultiCsv(file) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-String,System-String,System-Action{Bb-MultiCsv-FileReader}-'></a>
### LoadMultiCsv(file,rulePayload,initializer) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |
| rulePayload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The rule payload. |
| initializer | [System.Action{Bb.MultiCsv.FileReader}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.MultiCsv.FileReader}') | customize the reader. |

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-String,Bb-MultiCsv-IndentationRules-'></a>
### LoadMultiCsv(file,rules) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |
| rules | [Bb.MultiCsv.IndentationRules](#T-Bb-MultiCsv-IndentationRules 'Bb.MultiCsv.IndentationRules') | The rules. |

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo,System-String-'></a>
### LoadMultiCsv(file,rulePayload) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file. |
| rulePayload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The rule payload. |

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo,System-String,System-Action{Bb-MultiCsv-FileReader}-'></a>
### LoadMultiCsv(file,rulePayload,initializer) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file. |
| rulePayload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The rule payload. |
| initializer | [System.Action{Bb.MultiCsv.FileReader}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.MultiCsv.FileReader}') | customize the reader. |

##### Example

```Csharp
   var file = @"C:\Users\...\file.ext".AsFile();
   var f = file.LoadMultiCsv("BlockName1:SubBlock1|SubBlock2; SubBlock2|SubBlock3",
       c =&gt;
       {
           c.See("BlockName1", (c) =&gt;
           {
               return true;
           });
       }
       );
```

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo-'></a>
### LoadMultiCsv(file) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file. |

<a name='M-Bb-ContentHelperFiles-LoadMultiCsv-System-IO-FileInfo,Bb-MultiCsv-IndentationRules,System-Action{Bb-MultiCsv-FileReader}-'></a>
### LoadMultiCsv(file,rules,initializer) `method`

##### Summary

Loads the multi CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file to read. |
| rules | [Bb.MultiCsv.IndentationRules](#T-Bb-MultiCsv-IndentationRules 'Bb.MultiCsv.IndentationRules') | The rules. |
| initializer | [System.Action{Bb.MultiCsv.FileReader}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.MultiCsv.FileReader}') | customize the reader. |

<a name='M-Bb-ContentHelperFiles-LoadXmlFromFile-System-String,System-Text-Encoding-'></a>
### LoadXmlFromFile(sourcePath,defaultEncoding) `method`

##### Summary

Loads the content of the file and return XmlDocument.

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The source path segment. the path is concatenated with Path.Combine |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.InvalidDataException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.InvalidDataException 'System.IO.InvalidDataException') | if the sourcePath do not contains path |

<a name='M-Bb-ContentHelperFiles-LoadXmlFromFile-System-IO-FileInfo,System-Text-Encoding-'></a>
### LoadXmlFromFile(sourcePath,defaultEncoding) `method`

##### Summary

Loads the content of the file and return XmlDocument.

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The source path segment. the path is concatenated with Path.Combine |
| defaultEncoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.InvalidDataException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.InvalidDataException 'System.IO.InvalidDataException') | if the sourcePath do not contains path |

<a name='M-Bb-ContentHelperFiles-Md5-System-String-'></a>
### Md5(filePath) `method`

##### Summary

Generate the md5 checksum of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | if file not found |

<a name='M-Bb-ContentHelperFiles-Md5-System-IO-FileInfo-'></a>
### Md5(filePath) `method`

##### Summary

Generate the md5 checksum of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | if file not found |

<a name='M-Bb-ContentHelperFiles-OpenToWriteCsv-System-IO-FileInfo,System-String,System-String,System-String-'></a>
### OpenToWriteCsv(file,delimiter,quote,escape) `method`

##### Summary

Opens to write CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file. |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The delimiter. |
| quote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote. |
| escape | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape. |

<a name='M-Bb-ContentHelperFiles-OpenToWriteCsv-System-String,System-String,System-String,System-String-'></a>
### OpenToWriteCsv(file,delimiter,quote,escape) `method`

##### Summary

Opens to write CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The delimiter. |
| quote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote. |
| escape | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape. |

<a name='M-Bb-ContentHelperFiles-Read-System-IO-FileStream-'></a>
### Read(self) `method`

##### Summary

On a reader on the file stream and return a stream file. the default encoding is Utf8

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileStream 'System.IO.FileStream') | [FileInfo](#T-FileInfo 'FileInfo') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-ReadBigCsvToJson-System-String,System-Boolean,System-String,System-String,System-String-'></a>
### ReadBigCsvToJson(filename,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV on stream mode.

##### Returns

IEnumerable of Json object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The filename of the csv. |
| hasHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |
| escapeCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape charset.  By default the value is '/' |

<a name='M-Bb-ContentHelperFiles-ReadBigCsvToJson-System-IO-FileInfo,System-Boolean,System-String,System-String,System-String-'></a>
### ReadBigCsvToJson(file,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV on stream mode.

##### Returns

IEnumerable of Json object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file of the csv. |
| hasHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |
| escapeCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape charset.  By default the value is '/' |

##### Example

```csharp
 var file = Path.Combine(Environment.CurrentDirectory, "test1.csv").AsFile();
 foreach (var item2 in file.ReadBigCsvToJson(true, ";"))
 {
 }
 
```

<a name='M-Bb-ContentHelperFiles-ReadCsv-System-String,System-Action{System-Data-IDataReader,System-Int32,System-Int32},System-Boolean,System-String,System-String,System-String-'></a>
### ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The filename of the csv. |
| action | [System.Action{System.Data.IDataReader,System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Data.IDataReader,System.Int32,System.Int32}') | The action to execute for each lines of csv. |
| hasHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |
| escapeCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape charset.  By default the value is '/' |

<a name='M-Bb-ContentHelperFiles-ReadCsv-System-IO-FileInfo,System-Action{System-Data-IDataReader,System-Int32,System-Int32},System-Boolean,System-String,System-String,System-String-'></a>
### ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The filename of the csv. |
| action | [System.Action{System.Data.IDataReader,System.Int32,System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Data.IDataReader,System.Int32,System.Int32}') | The action to execute for each lines of csv. |
| hasHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |
| escapeCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape charset.  By default the value is '/' |

<a name='M-Bb-ContentHelperFiles-ReadCsv-System-String,System-Boolean,System-String,System-String,System-String-'></a>
### ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The filename of the csv. |
| action | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The action to execute for each lines of csv. |
| hasHeader | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |

<a name='M-Bb-ContentHelperFiles-ReadCsv-System-IO-FileInfo,System-Boolean,System-String,System-String,System-String-'></a>
### ReadCsv(filename,action,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file of the csv. |
| action | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The action to execute for each lines of csv. |
| hasHeader | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |

<a name='M-Bb-ContentHelperFiles-ReadCsvToJson-System-String,System-Boolean,System-String,System-String,System-String-'></a>
### ReadCsvToJson(filename,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV.

##### Returns

IEnumerable of Json object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The filename of the csv. |
| hasHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |
| escapeCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape charset.  By default the value is '/' |

<a name='M-Bb-ContentHelperFiles-ReadCsvToJson-System-IO-FileInfo,System-Boolean,System-String,System-String,System-String-'></a>
### ReadCsvToJson(file,hasHeader,charsetSeparator,quoteCharset,escapeCharset) `method`

##### Summary

Reads the CSV.

##### Returns

IEnumerable of Json object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file of the csv. |
| hasHeader | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has header]. By default the value is true |
| charsetSeparator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The charset separator. By default the value is ';' |
| quoteCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote charset. By default the value is '"' |
| escapeCharset | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape charset.  By default the value is '/' |

<a name='M-Bb-ContentHelperFiles-Save-System-String,System-String,System-Text-Encoding-'></a>
### Save(path,content,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the content payload to write |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Save-System-IO-FileInfo,System-String,System-Text-Encoding-'></a>
### Save(path,content,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the content payload to write |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Save-System-String,System-Text-StringBuilder,System-Text-Encoding-'></a>
### Save(path,content,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| content | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | the content payload to write |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Save-System-IO-FileInfo,System-Text-StringBuilder,System-Text-Encoding-'></a>
### Save(path,content,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| content | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | content payload to write |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Save-System-String,System-Func{System-String},System-Text-Encoding-'></a>
### Save(filename,payload,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| payload | [System.Func{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.String}') | function that return the content payload |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Save-System-IO-FileInfo,System-Func{System-String},System-Text-Encoding-'></a>
### Save(file,payload,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file target |
| payload | [System.Func{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.String}') | function that return the content payload |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Save-System-String,System-Text-Json-JsonDocument,System-Boolean,System-Text-Encoding-'></a>
### Save(filename,document,indented,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| document | [System.Text.Json.JsonDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonDocument 'System.Text.Json.JsonDocument') | object to serialize |
| indented | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [indented]. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-String,System-Object,System-Type-'></a>
### SerializeAndSaveConfiguration(filename,instance,sourceType) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | source type |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-String,System-Object,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeAndSaveConfiguration(filename,instance,sourceType,options) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | source type |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | options of serialization.[JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-IO-FileInfo,System-Object,System-Type-'></a>
### SerializeAndSaveConfiguration(file,instance,targetType) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | target type |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration-System-IO-FileInfo,System-Object,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeAndSaveConfiguration(file,instance,targetType,options) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | target type |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | options of serialization.[JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration``1-System-String,``0,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeAndSaveConfiguration\`\`1(filename,instance,options) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| instance | [\`\`0](#T-``0 '``0') | object to serialize |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | options of serialization.[JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of the source type. |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration``1-System-IO-FileInfo,``0-'></a>
### SerializeAndSaveConfiguration\`\`1(file,instance) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| instance | [\`\`0](#T-``0 '``0') | object to serialize |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of the source type. |

<a name='M-Bb-ContentHelperFiles-SerializeAndSaveConfiguration``1-System-IO-FileInfo,``0,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeAndSaveConfiguration\`\`1(file,instance,options) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| instance | [\`\`0](#T-``0 '``0') | object to serialize |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | options of serialization.[JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of the source type. |

<a name='M-Bb-ContentHelperFiles-SerializesAndSave-System-String,System-Object,System-Boolean,System-Text-Encoding-'></a>
### SerializesAndSave(filename,instance,indented,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |
| indented | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [indented]. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-SerializesAndSave-System-IO-FileInfo,System-Object,System-Boolean,System-Text-Encoding-'></a>
### SerializesAndSave(file,instance,indented,encoding) `method`

##### Summary

Save the content in the specified file.
If the directory don't exist. it is created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |
| instance | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |
| indented | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [indented]. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | encoding for write. if null the data are written in UTF8 |

<a name='M-Bb-ContentHelperFiles-Sha256-System-String-'></a>
### Sha256(filePath) `method`

##### Summary

Generate the sha256 checksum of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | if file not found |

<a name='M-Bb-ContentHelperFiles-Sha256-System-IO-FileInfo-'></a>
### Sha256(filePath) `method`

##### Summary

Generate the sha256 checksum of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | if file not found |

<a name='M-Bb-ContentHelperFiles-Sha512-System-String-'></a>
### Sha512(filePath) `method`

##### Summary

Generate the sha512 checksum of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file path |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | if file not found |

<a name='M-Bb-ContentHelperFiles-Sha512-System-IO-FileInfo-'></a>
### Sha512(filePath) `method`

##### Summary

Generate the sha512 checksum of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file path |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | if file not found |

<a name='M-Bb-ContentHelperFiles-StreamFromFile-System-IO-FileInfo-'></a>
### StreamFromFile(self) `method`

##### Summary

Load the content from file and return a stream file. the default encoding is Utf8

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='M-Bb-ContentHelperFiles-StreamFromFile-System-IO-FileInfo,System-Text-Encoding@-'></a>
### StreamFromFile(self,encoding) `method`

##### Summary

Load the content from file and return a stream file. If the encoding is not specified, the default encoding is Utf8

##### Returns

the content of the text document

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | [FileInfo](#T-FileInfo 'FileInfo') |
| encoding | [System.Text.Encoding@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding@ 'System.Text.Encoding@') | [Encoding](#T-Encoding 'Encoding')if null Utf8 is used by default |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | If self is null |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | If the file is not found |

<a name='T-Bb-Csv-CachedCsvReader-CsvBindingList'></a>
## CsvBindingList `type`

##### Namespace

Bb.Csv.CachedCsvReader

##### Summary

Represents a binding list wrapper for a CSV reader.

<a name='M-Bb-Csv-CachedCsvReader-CsvBindingList-#ctor-Bb-Csv-CachedCsvReader-'></a>
### #ctor(csv) `constructor`

##### Summary

Initializes a new instance of the CsvBindingList class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| csv | [Bb.Csv.CachedCsvReader](#T-Bb-Csv-CachedCsvReader 'Bb.Csv.CachedCsvReader') |  |

<a name='F-Bb-Csv-CachedCsvReader-CsvBindingList-_count'></a>
### _count `constants`

##### Summary

Contains the cached record count.

<a name='F-Bb-Csv-CachedCsvReader-CsvBindingList-_csv'></a>
### _csv `constants`

##### Summary

Contains the linked CSV reader.

<a name='F-Bb-Csv-CachedCsvReader-CsvBindingList-_direction'></a>
### _direction `constants`

##### Summary

Contains the current sort direction.

<a name='F-Bb-Csv-CachedCsvReader-CsvBindingList-_properties'></a>
### _properties `constants`

##### Summary

Contains the cached property descriptors.

<a name='F-Bb-Csv-CachedCsvReader-CsvBindingList-_sort'></a>
### _sort `constants`

##### Summary

Contains the current sort property.

<a name='T-Bb-Csv-CsvExtension'></a>
## CsvExtension `type`

##### Namespace

Bb.Csv

##### Summary

Csv extension

<a name='M-Bb-Csv-CsvExtension-ReaderCsv-System-IO-FileInfo,System-Boolean,System-Char,System-Char-'></a>
### ReaderCsv(self,hasHeaders,delimiter,quote) `method`

##### Summary

Readers the CSV.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The self. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [has headers]. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter. |
| quote | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The quote. |

<a name='T-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor'></a>
## CsvPropertyDescriptor `type`

##### Namespace

Bb.Csv.CachedCsvReader

##### Summary

Represents a CSV field property descriptor.

<a name='M-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor-#ctor-System-String,System-Int32-'></a>
### #ctor(fieldName,index) `constructor`

##### Summary

Initializes a new instance of the CsvPropertyDescriptor class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fieldName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The field name. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The field index. |

<a name='F-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor-_index'></a>
### _index `constants`

##### Summary

Contains the field index.

<a name='P-Bb-Csv-CachedCsvReader-CsvPropertyDescriptor-Index'></a>
### Index `property`

##### Summary

Gets the field index.

<a name='T-Bb-Csv-CsvReader'></a>
## CsvReader `type`

##### Namespace

Bb.Csv

##### Summary

Represents a reader that provides fast, non-cached, forward-only access to CSV data.

##### Example

```C#
<![CDATA[
            
                var _file = new FileInfo("filename");
                
                using (var _txt = _file.OpenText())
                {
                    using (CsvReader csv = new CsvReader(_txt, false, ';', '"', '\\', '#', ValueTrimmingOptions.All, (int)_file.Length))
                    {
                        
                        System.Data.IDataReader reader = csv;
                
                        while (reader.Read())
                        {
                        
                            var value = reader.GetValue("Column0");
                
                        }
                        
                    }
                }
                
            ]]>
```

<a name='M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean-'></a>
### #ctor(reader,hasHeaders) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Int32-'></a>
### #ctor(reader,hasHeaders,bufferSize) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The buffer size in bytes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char-'></a>
### #ctor(reader,hasHeaders,delimiter) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Int32-'></a>
### #ctor(reader,hasHeaders,delimiter,bufferSize) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The buffer size in bytes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Char,System-Char,System-Char,Bb-Csv-ValueTrimmingOptions-'></a>
### #ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |
| quote | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The quotation character wrapping every field (default is '''). |
| escape | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The escape character letting insert quotation characters inside a quoted field (default is '\').
If no escape character, set to '\0' to gain some performance. |
| comment | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The comment character indicating that a line is commented out (default is '#'). |
| trimmingOptions | [Bb.Csv.ValueTrimmingOptions](#T-Bb-Csv-ValueTrimmingOptions 'Bb.Csv.ValueTrimmingOptions') | Determines which values should be trimmed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | Cannot read from `reader`. |

<a name='M-Bb-Csv-CsvReader-#ctor-System-IO-TextReader,System-Boolean,System-Char,System-Nullable{System-Char},System-Char,System-Char,Bb-Csv-ValueTrimmingOptions,System-Int32-'></a>
### #ctor(reader,hasHeaders,delimiter,quote,escape,comment,trimmingOptions,bufferSize) `constructor`

##### Summary

Initializes a new instance of the CsvReader class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') | A [TextReader](#T-TextReader 'TextReader') pointing to the CSV file. |
| hasHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` if field names are located on the first non commented line, otherwise, `false`. |
| delimiter | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The delimiter character separating each field (default is ','). |
| quote | [System.Nullable{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Char}') | The quotation character wrapping every field (default is '''). |
| escape | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The escape character letting insert quotation characters inside a quoted field (default is '\').
If no escape character, set to '\0' to gain some performance. |
| comment | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The comment character indicating that a line is commented out (default is '#'). |
| trimmingOptions | [Bb.Csv.ValueTrimmingOptions](#T-Bb-Csv-ValueTrimmingOptions 'Bb.Csv.ValueTrimmingOptions') | Determines which values should be trimmed. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The buffer size in bytes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `bufferSize` must be 1 or more. |

<a name='F-Bb-Csv-CsvReader-DefaultBufferSize'></a>
### DefaultBufferSize `constants`

##### Summary

Defines the default buffer size.

<a name='F-Bb-Csv-CsvReader-DefaultComment'></a>
### DefaultComment `constants`

##### Summary

Defines the default comment character indicating that a line is commented out.

<a name='F-Bb-Csv-CsvReader-DefaultDelimiter'></a>
### DefaultDelimiter `constants`

##### Summary

Defines the default delimiter character separating each field.

<a name='F-Bb-Csv-CsvReader-DefaultEscape'></a>
### DefaultEscape `constants`

##### Summary

Defines the default escape character letting insert quotation characters inside a quoted field.

<a name='F-Bb-Csv-CsvReader-DefaultQuote'></a>
### DefaultQuote `constants`

##### Summary

Defines the default quote character wrapping every field.

<a name='F-Bb-Csv-CsvReader-_allocStack'></a>
### _allocStack `constants`

##### Summary

Contains the stack when the object was allocated.

<a name='F-Bb-Csv-CsvReader-_buffer'></a>
### _buffer `constants`

##### Summary

Contains the read buffer.

<a name='F-Bb-Csv-CsvReader-_bufferLength'></a>
### _bufferLength `constants`

##### Summary

Contains the current read buffer length.

<a name='F-Bb-Csv-CsvReader-_bufferSize'></a>
### _bufferSize `constants`

##### Summary

Contains the buffer size.

<a name='F-Bb-Csv-CsvReader-_comment'></a>
### _comment `constants`

##### Summary

Contains the comment character indicating that a line is commented out.

<a name='F-Bb-Csv-CsvReader-_currentRecordIndex'></a>
### _currentRecordIndex `constants`

##### Summary

Contains the current record index in the CSV file.
A value of [MinValue](#M-Int32-MinValue 'Int32.MinValue') means that the reader has not been initialized yet.
Otherwise, a negative value means that no record has been read yet.

<a name='F-Bb-Csv-CsvReader-_defaultParseErrorAction'></a>
### _defaultParseErrorAction `constants`

##### Summary

Contains the default action to take when a parsing error has occured.

<a name='F-Bb-Csv-CsvReader-_delimiter'></a>
### _delimiter `constants`

##### Summary

Contains the delimiter character separating each field.

<a name='F-Bb-Csv-CsvReader-_eof'></a>
### _eof `constants`

##### Summary

Indicates if the end of the reader has been reached.

<a name='F-Bb-Csv-CsvReader-_eol'></a>
### _eol `constants`

##### Summary

Indicates if the last read operation reached an EOL character.

<a name='F-Bb-Csv-CsvReader-_escape'></a>
### _escape `constants`

##### Summary

Contains the escape character letting insert quotation characters inside a quoted field.

<a name='F-Bb-Csv-CsvReader-_fieldCount'></a>
### _fieldCount `constants`

##### Summary

Contains the maximum number of fields to retrieve for each record.

<a name='F-Bb-Csv-CsvReader-_fieldHeaderComparer'></a>
### _fieldHeaderComparer `constants`

##### Summary

Contains the field header comparer.

<a name='F-Bb-Csv-CsvReader-_fieldHeaderIndexes'></a>
### _fieldHeaderIndexes `constants`

##### Summary

Contains the dictionary of field indexes by header. The key is the field name and the value is its index.

<a name='F-Bb-Csv-CsvReader-_fieldHeaders'></a>
### _fieldHeaders `constants`

##### Summary

Contains the field headers.

<a name='F-Bb-Csv-CsvReader-_fields'></a>
### _fields `constants`

##### Summary

Contains the array of the field values for the current record.
A null value indicates that the field have not been parsed.

<a name='F-Bb-Csv-CsvReader-_firstRecordInCache'></a>
### _firstRecordInCache `constants`

##### Summary

Indicates if the first record is in cache.
This can happen when initializing a reader with no headers
because one record must be read to get the field count automatically

<a name='F-Bb-Csv-CsvReader-_hasHeaders'></a>
### _hasHeaders `constants`

##### Summary

Indicates if field names are located on the first non commented line.

<a name='F-Bb-Csv-CsvReader-_initialized'></a>
### _initialized `constants`

##### Summary

Indicates if the class is initialized.

<a name='F-Bb-Csv-CsvReader-_isDisposed'></a>
### _isDisposed `constants`

##### Summary

Contains the disposed status flag.

<a name='F-Bb-Csv-CsvReader-_lock'></a>
### _lock `constants`

##### Summary

Contains the locking object for multi-threading purpose.

<a name='F-Bb-Csv-CsvReader-_missingFieldAction'></a>
### _missingFieldAction `constants`

##### Summary

Contains the action to take when a field is missing.

<a name='F-Bb-Csv-CsvReader-_missingFieldFlag'></a>
### _missingFieldFlag `constants`

##### Summary

Indicates if one or more field are missing for the current record.
Resets after each successful record read.

<a name='F-Bb-Csv-CsvReader-_nextFieldIndex'></a>
### _nextFieldIndex `constants`

##### Summary

Contains the index of the next unread field.

<a name='F-Bb-Csv-CsvReader-_nextFieldStart'></a>
### _nextFieldStart `constants`

##### Summary

Contains the starting position of the next unread field.

<a name='F-Bb-Csv-CsvReader-_parseErrorFlag'></a>
### _parseErrorFlag `constants`

##### Summary

Indicates if a parse error occured for the current record.
Resets after each successful record read.

<a name='F-Bb-Csv-CsvReader-_quote'></a>
### _quote `constants`

##### Summary

Contains the quotation character wrapping every field.

<a name='F-Bb-Csv-CsvReader-_reader'></a>
### _reader `constants`

##### Summary

Contains the [TextReader](#T-TextReader 'TextReader') pointing to the CSV file.

<a name='F-Bb-Csv-CsvReader-_skipEmptyLines'></a>
### _skipEmptyLines `constants`

##### Summary

Indicates if the reader will skip empty lines.

<a name='F-Bb-Csv-CsvReader-_supportsMultiline'></a>
### _supportsMultiline `constants`

##### Summary

Indicates if the reader supports multiline.

<a name='F-Bb-Csv-CsvReader-_trimmingOptions'></a>
### _trimmingOptions `constants`

##### Summary

Determines which values should be trimmed.

<a name='P-Bb-Csv-CsvReader-BufferSize'></a>
### BufferSize `property`

##### Summary

Gets the buffer size.

<a name='P-Bb-Csv-CsvReader-Comment'></a>
### Comment `property`

##### Summary

Gets the comment character indicating that a line is commented out.

<a name='P-Bb-Csv-CsvReader-CurrentRecordIndex'></a>
### CurrentRecordIndex `property`

##### Summary

Gets the current record index in the CSV file.

<a name='P-Bb-Csv-CsvReader-DefaultHeaderName'></a>
### DefaultHeaderName `property`

##### Summary

Gets or sets the default header name when it is an empty string or only whitespaces.
The header index will be appended to the specified name.

<a name='P-Bb-Csv-CsvReader-DefaultParseErrorAction'></a>
### DefaultParseErrorAction `property`

##### Summary

Gets or sets the default action to take when a parsing error has occured.

<a name='P-Bb-Csv-CsvReader-Delimiter'></a>
### Delimiter `property`

##### Summary

Gets the delimiter character separating each field.

<a name='P-Bb-Csv-CsvReader-EndOfStream'></a>
### EndOfStream `property`

##### Summary

Gets a value that indicates whether the current stream position is at the end of the stream.

<a name='P-Bb-Csv-CsvReader-Escape'></a>
### Escape `property`

##### Summary

Gets the escape character letting insert quotation characters inside a quoted field.

<a name='P-Bb-Csv-CsvReader-FieldCount'></a>
### FieldCount `property`

##### Summary

Gets the maximum number of fields to retrieve for each record.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='P-Bb-Csv-CsvReader-HasHeaders'></a>
### HasHeaders `property`

##### Summary

Indicates if field names are located on the first non commented line.

<a name='P-Bb-Csv-CsvReader-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether the instance has been disposed of.

<a name='P-Bb-Csv-CsvReader-Item-System-Int32,System-String-'></a>
### Item `property`

##### Summary

Gets the field with the specified name and record position. [hasHeaders](#M-hasHeaders 'hasHeaders') must be `true`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `field` is `null` or an empty string. |
| [InvalidOperationException](#T-InvalidOperationException 'InvalidOperationException') | The CSV does not have headers ([HasHeaders](#M-HasHeaders 'HasHeaders') property is `false`). |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | `field` not found. |
| [ArgumentOutOfRangeException](#T-ArgumentOutOfRangeException 'ArgumentOutOfRangeException') | Record index must be > 0. |
| [InvalidOperationException](#T-InvalidOperationException 'InvalidOperationException') | Cannot move to a previous record in forward-only mode. |
| [EndOfStreamException](#T-EndOfStreamException 'EndOfStreamException') | Cannot read record at `record`. |
| [MalformedCsvException](#T-MalformedCsvException 'MalformedCsvException') | The CSV appears to be corrupt at the current position. |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='P-Bb-Csv-CsvReader-Item-System-Int32,System-Int32-'></a>
### Item `property`

##### Summary

Gets the field at the specified index and record position.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentOutOfRangeException](#T-ArgumentOutOfRangeException 'ArgumentOutOfRangeException') | `field` must be included in [0, [FieldCount](#M-FieldCount 'FieldCount')[. |
| [ArgumentOutOfRangeException](#T-ArgumentOutOfRangeException 'ArgumentOutOfRangeException') | Record index must be > 0. |
| [InvalidOperationException](#T-InvalidOperationException 'InvalidOperationException') | Cannot move to a previous record in forward-only mode. |
| [EndOfStreamException](#T-EndOfStreamException 'EndOfStreamException') | Cannot read record at `record`. |
| [MalformedCsvException](#T-MalformedCsvException 'MalformedCsvException') | The CSV appears to be corrupt at the current position. |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='P-Bb-Csv-CsvReader-Item-System-String-'></a>
### Item `property`

##### Summary

Gets the field with the specified name. [hasHeaders](#M-hasHeaders 'hasHeaders') must be `true`.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `field` is `null` or an empty string. |
| [InvalidOperationException](#T-InvalidOperationException 'InvalidOperationException') | The CSV does not have headers ([HasHeaders](#M-HasHeaders 'HasHeaders') property is `false`). |
| [ArgumentException](#T-ArgumentException 'ArgumentException') | `field` not found. |
| [MalformedCsvException](#T-MalformedCsvException 'MalformedCsvException') | The CSV appears to be corrupt at the current position. |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='P-Bb-Csv-CsvReader-Item-System-Int32-'></a>
### Item `property`

##### Summary

Gets the field at the specified index.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentOutOfRangeException](#T-ArgumentOutOfRangeException 'ArgumentOutOfRangeException') | `field` must be included in [0, [FieldCount](#M-FieldCount 'FieldCount')[. |
| [InvalidOperationException](#T-InvalidOperationException 'InvalidOperationException') | No record read yet. Call ReadLine() first. |
| [MalformedCsvException](#T-MalformedCsvException 'MalformedCsvException') | The CSV appears to be corrupt at the current position. |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='P-Bb-Csv-CsvReader-MissingFieldAction'></a>
### MissingFieldAction `property`

##### Summary

Gets or sets the action to take when a field is missing.

<a name='P-Bb-Csv-CsvReader-MissingFieldFlag'></a>
### MissingFieldFlag `property`

##### Summary

Indicates if one or more field are missing for the current record.
Resets after each successful record read.

<a name='P-Bb-Csv-CsvReader-ParseErrorFlag'></a>
### ParseErrorFlag `property`

##### Summary

Indicates if a parse error occured for the current record.
Resets after each successful record read.

<a name='P-Bb-Csv-CsvReader-Quote'></a>
### Quote `property`

##### Summary

Gets the quotation character wrapping every field.

<a name='P-Bb-Csv-CsvReader-SkipEmptyLines'></a>
### SkipEmptyLines `property`

##### Summary

Gets or sets a value indicating if the reader will skip empty lines.

<a name='P-Bb-Csv-CsvReader-SupportsMultiline'></a>
### SupportsMultiline `property`

##### Summary

Gets or sets a value indicating if the reader supports multiline fields.

<a name='P-Bb-Csv-CsvReader-TrimmingOption'></a>
### TrimmingOption `property`

##### Summary

Indicates if spaces at the start and end of a field are trimmed.

<a name='M-Bb-Csv-CsvReader-CheckDisposed'></a>
### CheckDisposed() `method`

##### Summary

Checks if the instance has been disposed of, and if it has, throws an [ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException'); otherwise, does nothing.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

##### Remarks

Derived classes should call this method at the start of all methods and properties that should not be accessed after a call to [Dispose](#M-Dispose-- 'Dispose()').

<a name='M-Bb-Csv-CsvReader-CopyCurrentRecordTo-System-String[]-'></a>
### CopyCurrentRecordTo(array) `method`

##### Summary

Copies the field array of the current record to a one-dimensional array, starting at the beginning of the target array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The one-dimensional [Array](#T-Array 'Array') that is the destination of the fields of the current record. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `array` is `null`. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The number of fields in the record is greater than the available space from `array` to the end of `array`. |

<a name='M-Bb-Csv-CsvReader-CopyCurrentRecordTo-System-String[],System-Int32-'></a>
### CopyCurrentRecordTo(array,index) `method`

##### Summary

Copies the field array of the current record to a one-dimensional array, starting at the beginning of the target array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The one-dimensional [Array](#T-Array 'Array') that is the destination of the fields of the current record. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The zero-based index in `array` at which copying begins. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `array` is `null`. |
| [ArgumentOutOfRangeException](#T-ArgumentOutOfRangeException 'ArgumentOutOfRangeException') | `index` is les than zero or is equal to or greater than the length `array`. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | No current record. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | The number of fields in the record is greater than the available space from `index` to the end of `array`. |

<a name='M-Bb-Csv-CsvReader-CopyFieldToArray-System-Int32,System-Int64,System-Array,System-Int32,System-Int32-'></a>
### CopyFieldToArray(field,fieldOffset,destinationArray,destinationOffset,length) `method`

##### Summary

Copy the value of the specified field to an array.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the field. |
| fieldOffset | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The offset in the field value. |
| destinationArray | [System.Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array') | The destination array where the field value will be copied. |
| destinationOffset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The destination array offset. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of characters to copy from the field value. |

<a name='M-Bb-Csv-CsvReader-Dispose'></a>
### Dispose() `method`

##### Summary

Releases all resources used by the instance.

##### Parameters

This method has no parameters.

##### Remarks

Calls [Dispose](#M-Dispose-Boolean- 'Dispose(Boolean)') with the disposing parameter set to `true` to free unmanaged and managed resources.

<a name='M-Bb-Csv-CsvReader-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Releases the unmanaged resources used by this instance and optionally releases the managed resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to release both managed and unmanaged resources; `false` to release only unmanaged resources. |

<a name='M-Bb-Csv-CsvReader-DoSkipEmptyAndCommentedLines-System-Int32@-'></a>
### DoSkipEmptyAndCommentedLines(pos) `method`

##### Summary

Worker method.

Skips empty and commented lines.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The position in the buffer where to start parsing. 
Will contains the resulting position after the operation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-EnsureInitialize'></a>
### EnsureInitialize() `method`

##### Summary

Ensures that the reader is initialized.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CsvReader-Finalize'></a>
### Finalize() `method`

##### Summary

Releases unmanaged resources and performs other cleanup operations before the instance is reclaimed by garbage collection.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CsvReader-GetCurrentRawData-System-Int32,System-Int32-'></a>
### GetCurrentRawData() `method`

##### Summary

Gets the current raw CSV data.

##### Returns

The current raw CSV data.

##### Parameters

This method has no parameters.

##### Remarks

Used for exception handling purpose.

<a name='M-Bb-Csv-CsvReader-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an [RecordEnumerator](#T-RecordEnumerator 'RecordEnumerator') that can iterate through CSV records.

##### Returns

An [RecordEnumerator](#T-RecordEnumerator 'RecordEnumerator') that can iterate through CSV records.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-GetFieldHeaders'></a>
### GetFieldHeaders() `method`

##### Summary

Gets the field headers.

##### Returns

The field headers or an empty array if headers are not supported.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-GetFieldIndex-System-String-'></a>
### GetFieldIndex(header) `method`

##### Summary

Gets the field index for the provided header.

##### Returns

The field index for the provided header. -1 if not found.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The header to look for. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-HandleMissingField-System-String,System-Int32,System-Int32@-'></a>
### HandleMissingField(value,fieldIndex,currentPosition) `method`

##### Summary

Handles a missing field error.

##### Returns

The resulting value according to [MissingFieldAction](#M-MissingFieldAction 'MissingFieldAction').
If the action is set to [TreatAsParseError](#T-MissingFieldAction-TreatAsParseError 'MissingFieldAction.TreatAsParseError'),
then the parse error will be handled according to [DefaultParseErrorAction](#P-Bb-Csv-CsvReader-DefaultParseErrorAction 'Bb.Csv.CsvReader.DefaultParseErrorAction').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The partially parsed value, if available. |
| fieldIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The missing field index. |
| currentPosition | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The current position in the raw data. |

<a name='M-Bb-Csv-CsvReader-HandleParseError-Bb-Csv-Exceptions-MalformedCsvException,System-Int32@-'></a>
### HandleParseError(error,pos) `method`

##### Summary

Handles a parsing error.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| error | [Bb.Csv.Exceptions.MalformedCsvException](#T-Bb-Csv-Exceptions-MalformedCsvException 'Bb.Csv.Exceptions.MalformedCsvException') | The parsing error that occured. |
| pos | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The current position in the buffer. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `error` is `null`. |

<a name='M-Bb-Csv-CsvReader-IsNewLine-System-Int32-'></a>
### IsNewLine(pos) `method`

##### Summary

Determines whether the character at the specified position is a new line delimiter.

##### Returns

`true` if the character at the specified position is a new line delimiter; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The position of the character to verify. |

<a name='M-Bb-Csv-CsvReader-IsWhiteSpace-System-Char-'></a>
### IsWhiteSpace(c) `method`

##### Summary

Indicates whether the specified Unicode character is categorized as white space.

##### Returns

`true` if `c` is white space; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| c | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | A Unicode character. |

<a name='M-Bb-Csv-CsvReader-MoveTo-System-Int64-'></a>
### MoveTo(record) `method`

##### Summary

Moves to the specified record index.

##### Returns

`true` if the operation was successful; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| record | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The record index. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-OnDisposed-System-EventArgs-'></a>
### OnDisposed(e) `method`

##### Summary

Raises the [Disposed](#M-Disposed 'Disposed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

<a name='M-Bb-Csv-CsvReader-OnParseError-Bb-Csv-Events-ParseErrorEventArgs-'></a>
### OnParseError(e) `method`

##### Summary

Raises the [ParseError](#M-ParseError 'ParseError') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [Bb.Csv.Events.ParseErrorEventArgs](#T-Bb-Csv-Events-ParseErrorEventArgs 'Bb.Csv.Events.ParseErrorEventArgs') | The [ParseErrorEventArgs](#T-Bb-Csv-Events-ParseErrorEventArgs 'Bb.Csv.Events.ParseErrorEventArgs') that contains the event data. |

<a name='M-Bb-Csv-CsvReader-ParseNewLine-System-Int32@-'></a>
### ParseNewLine(pos) `method`

##### Summary

Parses a new line delimiter.

##### Returns

`true` if a new line delimiter was found; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The starting position of the parsing. Will contain the resulting end position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-ReadBuffer'></a>
### ReadBuffer() `method`

##### Summary

Fills the buffer with data from the reader.

##### Returns

`true` if data was successfully read; otherwise, `false`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-ReadField-System-Int32,System-Boolean,System-Boolean-'></a>
### ReadField(field,initializing,discardValue) `method`

##### Summary

Reads the field at the specified index.
Any unread fields with an inferior index will also be read as part of the required parsing.

##### Returns

The field at the specified index. 
A `null` indicates that an error occured or that the last field has been reached during initialization.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The field index. |
| initializing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates if the reader is currently initializing. |
| discardValue | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates if the value(s) are discarded. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | `field` is out of range. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | There is no current record. |
| [Bb.Csv.Exceptions.MissingFieldCsvException](#T-Bb-Csv-Exceptions-MissingFieldCsvException 'Bb.Csv.Exceptions.MissingFieldCsvException') | The CSV data appears to be missing a field. |
| [Bb.Csv.Exceptions.MalformedCsvException](#T-Bb-Csv-Exceptions-MalformedCsvException 'Bb.Csv.Exceptions.MalformedCsvException') | The CSV data appears to be malformed. |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-ReadNextRecord'></a>
### ReadNextRecord() `method`

##### Summary

Reads the next record.

##### Returns

`true` if a record has been successfully reads; otherwise, `false`.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-ReadNextRecord-System-Boolean,System-Boolean-'></a>
### ReadNextRecord(onlyReadHeaders,skipToNextLine) `method`

##### Summary

Reads the next record.

##### Returns

`true` if a record has been successfully reads; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyReadHeaders | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates if the reader will proceed to the next record after having read headers.
`true` if it stops after having read headers; otherwise, `false`. |
| skipToNextLine | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates if the reader will skip directly to the next line without parsing the current one. 
To be used when an error occurs. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-SkipEmptyAndCommentedLines-System-Int32@-'></a>
### SkipEmptyAndCommentedLines(pos) `method`

##### Summary

Skips empty and commented lines.
If the end of the buffer is reached, its content be discarded and filled again from the reader.

##### Returns

`true` if the end of the reader has not been reached; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The position in the buffer where to start parsing. 
Will contains the resulting position after the operation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-SkipToNextLine-System-Int32@-'></a>
### SkipToNextLine(pos) `method`

##### Summary

Skips ahead to the next NewLine character.
If the end of the buffer is reached, its content be discarded and filled again from the reader.

##### Returns

`true` if the end of the reader has not been reached; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The position in the buffer where to start parsing. 
Will contains the resulting position after the operation. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-SkipWhiteSpaces-System-Int32@-'></a>
### SkipWhiteSpaces(pos) `method`

##### Summary

Skips whitespace characters.

##### Returns

`true` if the end of the reader has not been reached; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pos | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The starting position of the parsing. Will contain the resulting end position. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-System#Collections#Generic#IEnumerable{System#String[]}#GetEnumerator'></a>
### System#Collections#Generic#IEnumerable{System#String[]}#GetEnumerator() `method`

##### Summary

Returns an [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generics.IEnumerator 'System.Collections.Generics.IEnumerator') that can iterate through CSV records.

##### Returns

An [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generics.IEnumerator 'System.Collections.Generics.IEnumerator') that can iterate through CSV records.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') that can iterate through CSV records.

##### Returns

An [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') that can iterate through CSV records.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ComponentModel.ObjectDisposedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ObjectDisposedException 'System.ComponentModel.ObjectDisposedException') | The instance has been disposed of. |

<a name='M-Bb-Csv-CsvReader-ValidateDataReader-Bb-Csv-CsvReader-DataReaderValidations-'></a>
### ValidateDataReader(validations) `method`

##### Summary

Validates the state of the data reader.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validations | [Bb.Csv.CsvReader.DataReaderValidations](#T-Bb-Csv-CsvReader-DataReaderValidations 'Bb.Csv.CsvReader.DataReaderValidations') | The validations to accomplish. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | No current record. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | This operation is invalid when the reader is closed. |

<a name='T-Bb-Csv-CachedCsvReader-CsvRecordComparer'></a>
## CsvRecordComparer `type`

##### Namespace

Bb.Csv.CachedCsvReader

##### Summary

Represents a CSV record comparer.

<a name='M-Bb-Csv-CachedCsvReader-CsvRecordComparer-#ctor-System-Int32,System-ComponentModel-ListSortDirection-'></a>
### #ctor(field,direction) `constructor`

##### Summary

Initializes a new instance of the CsvRecordComparer class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The field index of the values to compare. |
| direction | [System.ComponentModel.ListSortDirection](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.ListSortDirection 'System.ComponentModel.ListSortDirection') | The sort direction. |

<a name='F-Bb-Csv-CachedCsvReader-CsvRecordComparer-_direction'></a>
### _direction `constants`

##### Summary

Contains the sort direction.

<a name='F-Bb-Csv-CachedCsvReader-CsvRecordComparer-_field'></a>
### _field `constants`

##### Summary

Contains the field index of the values to compare.

<a name='T-Bb-Csv-CsvWriter'></a>
## CsvWriter `type`

##### Namespace

Bb.Csv

##### Summary

manage csv file

##### Example

```C#
<![CDATA[
             
                var fileToRead = new FileInfo(Path.Combine("...", "read.csv"));
                var fileToWrite = new FileInfo(Path.Combine("...", "write.csv"));
            
                using (var writer = fileToWrite.OpenToWriteCsv())
                {
            
                    writer.WriteHeaders("Id", "value");
            
                    foreach (var item2 in fileToRead.ReadBigCsvToJson(true))
                    {
                        var id = item2["Id"].GetValue<int>();
                        var id = item2["Value"].GetValue<int>();
                        writer.WriteLine(id, value);
                    }
            
                }
             ]]>
```

##### See Also

- [System.IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable')

<a name='M-Bb-Csv-CsvWriter-#ctor-System-String,System-String,System-String-'></a>
### #ctor(delimiter,quote,escape) `constructor`

##### Summary

Initializes a new instance of the [CsvWriter](#T-Bb-Csv-CsvWriter 'Bb.Csv.CsvWriter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The delimiter. |
| quote | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The quote. |
| escape | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The escape. |

<a name='M-Bb-Csv-CsvWriter-Close'></a>
### Close() `method`

##### Summary

Closes this instance.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CsvWriter-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Releases unmanaged and - optionally - managed resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to release both managed and unmanaged resources; `false` to release only unmanaged resources. |

<a name='M-Bb-Csv-CsvWriter-Flush'></a>
### Flush() `method`

##### Summary

Flushes this instance.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CsvWriter-Open-System-String,System-Text-Encoding-'></a>
### Open(file,encoding) `method`

##### Summary

Opens the specified file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The encoding. |

<a name='M-Bb-Csv-CsvWriter-Open-System-IO-FileInfo,System-Text-Encoding-'></a>
### Open(file,encoding) `method`

##### Summary

Opens the specified file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The encoding. |

<a name='M-Bb-Csv-CsvWriter-WriteHeaders-System-String[]-'></a>
### WriteHeaders(hearders) `method`

##### Summary

Writes the header.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hearders | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The header list. |

<a name='M-Bb-Csv-CsvWriter-WriteLine-System-Object[]-'></a>
### WriteLine(datas) `method`

##### Summary

Writes the line.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datas | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The datas. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.InvalidDataException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.InvalidDataException 'System.IO.InvalidDataException') | Invalid data length |

<a name='M-Bb-Csv-CsvWriter-WriteLines-System-Collections-Generic-IEnumerable{System-Object[]}-'></a>
### WriteLines(datas) `method`

##### Summary

Writes the specified datas.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datas | [System.Collections.Generic.IEnumerable{System.Object[]}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Object[]}') | The datas. |

<a name='T-Bb-Csv-CsvReader-DataReaderValidations'></a>
## DataReaderValidations `type`

##### Namespace

Bb.Csv.CsvReader

##### Summary

Defines the data reader validations.

<a name='F-Bb-Csv-CsvReader-DataReaderValidations-IsInitialized'></a>
### IsInitialized `constants`

##### Summary

Validate that the data reader is initialized.

<a name='F-Bb-Csv-CsvReader-DataReaderValidations-IsNotClosed'></a>
### IsNotClosed `constants`

##### Summary

Validate that the data reader is not closed.

<a name='F-Bb-Csv-CsvReader-DataReaderValidations-None'></a>
### None `constants`

##### Summary

No validation.

<a name='T-Bb-Csv-ExceptionMessage'></a>
## ExceptionMessage `type`

##### Namespace

Bb.Csv

##### Summary

Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.

<a name='P-Bb-Csv-ExceptionMessage-BufferSizeTooSmall'></a>
### BufferSizeTooSmall `property`

##### Summary

Recherche une chaîne localisée semblable à Buffer size must be 1 or more..

<a name='P-Bb-Csv-ExceptionMessage-CannotMovePreviousRecordInForwardOnly'></a>
### CannotMovePreviousRecordInForwardOnly `property`

##### Summary

Recherche une chaîne localisée semblable à Cannot move to a previous record in forward-only mode..

<a name='P-Bb-Csv-ExceptionMessage-CannotReadRecordAtIndex'></a>
### CannotReadRecordAtIndex `property`

##### Summary

Recherche une chaîne localisée semblable à Cannot read record at index '{0}'..

<a name='P-Bb-Csv-ExceptionMessage-Culture'></a>
### Culture `property`

##### Summary

Remplace la propriété CurrentUICulture du thread actuel pour toutes
  les recherches de ressources à l'aide de cette classe de ressource fortement typée.

<a name='P-Bb-Csv-ExceptionMessage-EnumerationFinishedOrNotStarted'></a>
### EnumerationFinishedOrNotStarted `property`

##### Summary

Recherche une chaîne localisée semblable à Enumeration has either not started or has already finished..

<a name='P-Bb-Csv-ExceptionMessage-EnumerationVersionCheckFailed'></a>
### EnumerationVersionCheckFailed `property`

##### Summary

Recherche une chaîne localisée semblable à Collection was modified; enumeration operation may not execute..

<a name='P-Bb-Csv-ExceptionMessage-FieldHeaderNotFound'></a>
### FieldHeaderNotFound `property`

##### Summary

Recherche une chaîne localisée semblable à '{0}' field header not found..

<a name='P-Bb-Csv-ExceptionMessage-FieldIndexOutOfRange'></a>
### FieldIndexOutOfRange `property`

##### Summary

Recherche une chaîne localisée semblable à Field index must be included in [0, FieldCount[. Specified field index was : '{0}'..

<a name='P-Bb-Csv-ExceptionMessage-MalformedCsvException'></a>
### MalformedCsvException `property`

##### Summary

Recherche une chaîne localisée semblable à The CSV appears to be corrupt near record '{0}' field '{1} at position '{2}'. Current raw data : '{3}'..

<a name='P-Bb-Csv-ExceptionMessage-MissingFieldActionNotSupported'></a>
### MissingFieldActionNotSupported `property`

##### Summary

Recherche une chaîne localisée semblable à '{0}' is not a supported missing field action..

<a name='P-Bb-Csv-ExceptionMessage-NoCurrentRecord'></a>
### NoCurrentRecord `property`

##### Summary

Recherche une chaîne localisée semblable à No current record..

<a name='P-Bb-Csv-ExceptionMessage-NoHeaders'></a>
### NoHeaders `property`

##### Summary

Recherche une chaîne localisée semblable à The CSV does not have headers (CsvReader.HasHeaders property is false)..

<a name='P-Bb-Csv-ExceptionMessage-NotEnoughSpaceInArray'></a>
### NotEnoughSpaceInArray `property`

##### Summary

Recherche une chaîne localisée semblable à The number of fields in the record is greater than the available space from index to the end of the destination array..

<a name='P-Bb-Csv-ExceptionMessage-ParseErrorActionInvalidInsideParseErrorEvent'></a>
### ParseErrorActionInvalidInsideParseErrorEvent `property`

##### Summary

Recherche une chaîne localisée semblable à '{0}' is not a valid ParseErrorAction while inside a ParseError event..

<a name='P-Bb-Csv-ExceptionMessage-ParseErrorActionNotSupported'></a>
### ParseErrorActionNotSupported `property`

##### Summary

Recherche une chaîne localisée semblable à '{0}' is not a supported ParseErrorAction..

<a name='P-Bb-Csv-ExceptionMessage-ReaderClosed'></a>
### ReaderClosed `property`

##### Summary

Recherche une chaîne localisée semblable à This operation is invalid when the reader is closed..

<a name='P-Bb-Csv-ExceptionMessage-RecordIndexLessThanZero'></a>
### RecordIndexLessThanZero `property`

##### Summary

Recherche une chaîne localisée semblable à Record index must be 0 or more.

<a name='P-Bb-Csv-ExceptionMessage-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Retourne l'instance ResourceManager mise en cache utilisée par cette classe.

<a name='T-Bb-MultiCsv-FileInformations'></a>
## FileInformations `type`

##### Namespace

Bb.MultiCsv

##### Summary

Class FileInformations

<a name='M-Bb-MultiCsv-FileInformations-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [FileInformations](#T-Bb-MultiCsv-FileInformations 'Bb.MultiCsv.FileInformations') class.

##### Parameters

This constructor has no parameters.

<a name='F-Bb-MultiCsv-FileInformations-_headers'></a>
### _headers `constants`

##### Summary

The _headers

<a name='P-Bb-MultiCsv-FileInformations-EncodingByUde'></a>
### EncodingByUde `property`

##### Summary

Get encoding detected by the Ude library

<a name='P-Bb-MultiCsv-FileInformations-FileInfo'></a>
### FileInfo `property`

##### Summary

Gets or sets the file information.

<a name='P-Bb-MultiCsv-FileInformations-Headers'></a>
### Headers `property`

##### Summary

Gets the headers.

<a name='M-Bb-MultiCsv-FileInformations-GetHeader-System-String,System-String-'></a>
### GetHeader(e) `method`

##### Summary

Gets the header.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The e. |

<a name='T-Bb-MultiCsv-FileReader'></a>
## FileReader `type`

##### Namespace

Bb.MultiCsv

##### Summary

File reader

<a name='P-Bb-MultiCsv-FileReader-FileInformations'></a>
### FileInformations `property`

##### Summary

File informations

<a name='M-Bb-MultiCsv-FileReader-FileReadFile-System-String,System-String,System-Action{Bb-MultiCsv-FileReader}-'></a>
### FileReadFile(filePath,rulePayload,initializer) `method`

##### Summary

Initializes a new instance of the [FileReader](#T-Bb-MultiCsv-FileReader 'Bb.MultiCsv.FileReader') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| rulePayload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| initializer | [System.Action{Bb.MultiCsv.FileReader}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.MultiCsv.FileReader}') |  |

<a name='M-Bb-MultiCsv-FileReader-FileReadFile-System-String,Bb-MultiCsv-IndentationRules,System-Action{Bb-MultiCsv-FileReader}-'></a>
### FileReadFile(filePath,rulePayload,initializer) `method`

##### Summary

Initializes a new instance of the [FileReader](#T-Bb-MultiCsv-FileReader 'Bb.MultiCsv.FileReader') class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| rulePayload | [Bb.MultiCsv.IndentationRules](#T-Bb-MultiCsv-IndentationRules 'Bb.MultiCsv.IndentationRules') |  |
| initializer | [System.Action{Bb.MultiCsv.FileReader}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.MultiCsv.FileReader}') |  |

<a name='M-Bb-MultiCsv-FileReader-See-System-String,System-Func{Bb-MultiCsv-Block,System-Boolean}-'></a>
### See(see,filter) `method`

##### Summary

Intercepts the block to see.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| see | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| filter | [System.Func{Bb.MultiCsv.Block,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.MultiCsv.Block,System.Boolean}') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='T-Bb-MultiCsv-HeaderReference'></a>
## HeaderReference `type`

##### Namespace

Bb.MultiCsv

##### Summary

Header Reference

<a name='M-Bb-MultiCsv-HeaderReference-#ctor-System-String,System-String-'></a>
### #ctor(headerName) `constructor`

##### Summary

Initializes a new instance of the [HeaderReference](#T-Bb-MultiCsv-HeaderReference 'Bb.MultiCsv.HeaderReference') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| headerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The e. |

<a name='P-Bb-MultiCsv-HeaderReference-LabelLine'></a>
### LabelLine `property`

##### Summary

Gets the title of the line.

<a name='P-Bb-MultiCsv-HeaderReference-Schema'></a>
### Schema `property`

##### Summary

Gets the schema of the line.

<a name='T-Bb-MultiCsv-IndentationRule'></a>
## IndentationRule `type`

##### Namespace

Bb.MultiCsv

##### Summary

Indentation rule

<a name='M-Bb-MultiCsv-IndentationRule-#ctor-System-String-'></a>
### #ctor(rule) `constructor`

##### Summary

Initializes a new instance of the [IndentationRule](#T-Bb-MultiCsv-IndentationRule 'Bb.MultiCsv.IndentationRule') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rule | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Bb-MultiCsv-IndentationRule-Children'></a>
### Children `property`

##### Summary

Items of the rule

<a name='P-Bb-MultiCsv-IndentationRule-Key'></a>
### Key `property`

##### Summary

Key of the rule

<a name='T-Bb-MultiCsv-IndentationRules'></a>
## IndentationRules `type`

##### Namespace

Bb.MultiCsv

##### Summary

List of rules

<a name='M-Bb-MultiCsv-IndentationRules-#ctor-System-String-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [IndentationRules](#T-Bb-MultiCsv-IndentationRules 'Bb.MultiCsv.IndentationRules') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Bb-MultiCsv-IndentationRules-HasRule'></a>
### HasRule `property`

##### Summary

contains rules

<a name='M-Bb-MultiCsv-IndentationRules-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Determines whether the specified object is equal to the current object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-Bb-MultiCsv-IndentationRules-EvaluateIfEmbeddedInParent-Bb-MultiCsv-Block,Bb-MultiCsv-Block-'></a>
### EvaluateIfEmbeddedInParent(parent,child) `method`

##### Summary

Return true if the child is embedded in the parent otherwise false if the items have same parent.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parent | [Bb.MultiCsv.Block](#T-Bb-MultiCsv-Block 'Bb.MultiCsv.Block') | parent |
| child | [Bb.MultiCsv.Block](#T-Bb-MultiCsv-Block 'Bb.MultiCsv.Block') | item that is maybe a child |

<a name='T-Bb-MultiCsv-Lexer'></a>
## Lexer `type`

##### Namespace

Bb.MultiCsv

##### Summary

Interpreter design pattern:
To parse file we are using a lexing as described in Interpreter design pattern

<a name='M-Bb-MultiCsv-Lexer-#ctor-System-String,System-Text-Encoding-'></a>
### #ctor(file,encoding) `constructor`

##### Summary

Initializes a new instance of the [Lexer](#T-Bb-MultiCsv-Lexer 'Bb.MultiCsv.Lexer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The encoding. |

<a name='P-Bb-MultiCsv-Lexer-Current'></a>
### Current `property`

##### Summary

Gets the current.

<a name='M-Bb-MultiCsv-Lexer-Close'></a>
### Close() `method`

##### Summary

Close file

##### Parameters

This method has no parameters.

<a name='M-Bb-MultiCsv-Lexer-Dispose'></a>
### Dispose() `method`

##### Summary

Exécute les tâches définies par l'application associées à la libération ou à la redéfinition des ressources non managées.

##### Parameters

This method has no parameters.

<a name='M-Bb-MultiCsv-Lexer-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Releases unmanaged and - optionally - managed resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to release both managed and unmanaged resources; `false` to release only unmanaged resources. |

<a name='M-Bb-MultiCsv-Lexer-Finalize'></a>
### Finalize() `method`

##### Summary

Finalizes an instance of the [Lexer](#T-Bb-MultiCsv-Lexer 'Bb.MultiCsv.Lexer') class.

##### Parameters

This method has no parameters.

<a name='M-Bb-MultiCsv-Lexer-GetLine'></a>
### GetLine() `method`

##### Summary

Get next line automatically converted into a block. Header is implicitly processed here

##### Returns

Block

##### Parameters

This method has no parameters.

<a name='M-Bb-MultiCsv-Lexer-MoveNext'></a>
### MoveNext() `method`

##### Summary

Moves the next.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-MultiCsv-Lexer-Open-System-Text-Encoding-'></a>
### Open() `method`

##### Summary

open file and get encoding of file with the Ude library

##### Parameters

This method has no parameters.

<a name='M-Bb-MultiCsv-Lexer-ReadDef-System-String[]-'></a>
### ReadDef(s) `method`

##### Summary

Parse Def line. It is corresponding to a header definition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Bb-MultiCsv-Lexer-ReadLine-System-String@-'></a>
### ReadLine() `method`

##### Summary

Get next line (Raw data), parse it as a csv file with ';' separator

##### Returns

splitted string into an array resulting of csv parsing

##### Parameters

This method has no parameters.

<a name='T-Bb-Csv-Exceptions-MalformedCsvException'></a>
## MalformedCsvException `type`

##### Namespace

Bb.Csv.Exceptions

##### Summary

Represents the exception that is thrown when a CSV file is malformed.

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the MalformedCsvException class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the MalformedCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the MalformedCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32-'></a>
### #ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex) `constructor`

##### Summary

Initializes a new instance of the MalformedCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data when the error occured. |
| currentPosition | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current position in the raw data. |
| currentRecordIndex | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The current record index. |
| currentFieldIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current field index. |

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32,System-Exception-'></a>
### #ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex,innerException) `constructor`

##### Summary

Initializes a new instance of the MalformedCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data when the error occured. |
| currentPosition | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current position in the raw data. |
| currentRecordIndex | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The current record index. |
| currentFieldIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current field index. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(info,context) `constructor`

##### Summary

Initializes a new instance of the MalformedCsvException class with serialized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The [SerializationInfo](#T-SerializationInfo 'SerializationInfo') that holds the serialized object data about the exception being thrown. |
| context | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The [StreamingContext](#T-StreamingContext 'StreamingContext') that contains contextual information about the source or destination. |

<a name='F-Bb-Csv-Exceptions-MalformedCsvException-_currentFieldIndex'></a>
### _currentFieldIndex `constants`

##### Summary

Contains the current field index.

<a name='F-Bb-Csv-Exceptions-MalformedCsvException-_currentPosition'></a>
### _currentPosition `constants`

##### Summary

Contains the current position in the raw data.

<a name='F-Bb-Csv-Exceptions-MalformedCsvException-_currentRecordIndex'></a>
### _currentRecordIndex `constants`

##### Summary

Contains the current record index.

<a name='F-Bb-Csv-Exceptions-MalformedCsvException-_message'></a>
### _message `constants`

##### Summary

Contains the message that describes the error.

<a name='F-Bb-Csv-Exceptions-MalformedCsvException-_rawData'></a>
### _rawData `constants`

##### Summary

Contains the raw data when the error occured.

<a name='P-Bb-Csv-Exceptions-MalformedCsvException-CurrentFieldIndex'></a>
### CurrentFieldIndex `property`

##### Summary

Gets the current field index.

<a name='P-Bb-Csv-Exceptions-MalformedCsvException-CurrentPosition'></a>
### CurrentPosition `property`

##### Summary

Gets the current position in the raw data.

<a name='P-Bb-Csv-Exceptions-MalformedCsvException-CurrentRecordIndex'></a>
### CurrentRecordIndex `property`

##### Summary

Gets the current record index.

<a name='P-Bb-Csv-Exceptions-MalformedCsvException-Message'></a>
### Message `property`

##### Summary

Gets a message that describes the current exception.

<a name='P-Bb-Csv-Exceptions-MalformedCsvException-RawData'></a>
### RawData `property`

##### Summary

Gets the raw data when the error occured.

<a name='M-Bb-Csv-Exceptions-MalformedCsvException-GetObjectData-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### GetObjectData(info,context) `method`

##### Summary

When overridden in a derived class, sets the [SerializationInfo](#T-SerializationInfo 'SerializationInfo') with information about the exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The [SerializationInfo](#T-SerializationInfo 'SerializationInfo') that holds the serialized object data about the exception being thrown. |
| context | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The [StreamingContext](#T-StreamingContext 'StreamingContext') that contains contextual information about the source or destination. |

<a name='T-Bb-Csv-MissingFieldAction'></a>
## MissingFieldAction `type`

##### Namespace

Bb.Csv

##### Summary

Specifies the action to take when a field is missing.

<a name='F-Bb-Csv-MissingFieldAction-ParseError'></a>
### ParseError `constants`

##### Summary

Treat as a parsing error.

<a name='F-Bb-Csv-MissingFieldAction-ReplaceByEmpty'></a>
### ReplaceByEmpty `constants`

##### Summary

Replaces by an empty value.

<a name='F-Bb-Csv-MissingFieldAction-ReplaceByNull'></a>
### ReplaceByNull `constants`

##### Summary

Replaces by a null value (`null`).

<a name='T-Bb-Csv-Exceptions-MissingFieldCsvException'></a>
## MissingFieldCsvException `type`

##### Namespace

Bb.Csv.Exceptions

##### Summary

Represents the exception that is thrown when a there is a missing field in a record of the CSV file.

##### Remarks

MissingFieldException would have been a better name, but there is already a [MissingFieldException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.MissingFieldException 'System.MissingFieldException').

<a name='M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the MissingFieldCsvException class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the MissingFieldCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |

<a name='M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new instance of the MissingFieldCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

<a name='M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32-'></a>
### #ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex) `constructor`

##### Summary

Initializes a new instance of the MissingFieldCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data when the error occured. |
| currentPosition | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current position in the raw data. |
| currentRecordIndex | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The current record index. |
| currentFieldIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current field index. |

<a name='M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-String,System-Int32,System-Int64,System-Int32,System-Exception-'></a>
### #ctor(rawData,currentPosition,currentRecordIndex,currentFieldIndex,innerException) `constructor`

##### Summary

Initializes a new instance of the MissingFieldCsvException class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data when the error occured. |
| currentPosition | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current position in the raw data. |
| currentRecordIndex | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The current record index. |
| currentFieldIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The current field index. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

<a name='M-Bb-Csv-Exceptions-MissingFieldCsvException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(info,context) `constructor`

##### Summary

Initializes a new instance of the MissingFieldCsvException class with serialized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | The [SerializationInfo](#T-SerializationInfo 'SerializationInfo') that holds the serialized object data about the exception being thrown. |
| context | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | The [StreamingContext](#T-StreamingContext 'StreamingContext') that contains contextual information about the source or destination. |

<a name='T-Bb-Csv-ParseErrorAction'></a>
## ParseErrorAction `type`

##### Namespace

Bb.Csv

##### Summary

Specifies the action to take when a parsing error has occured.

<a name='F-Bb-Csv-ParseErrorAction-AdvanceToNextLine'></a>
### AdvanceToNextLine `constants`

##### Summary

Tries to advance to next line.

<a name='F-Bb-Csv-ParseErrorAction-RaiseEvent'></a>
### RaiseEvent `constants`

##### Summary

Raises the [ParseError](#M-CsvReader-ParseError 'CsvReader.ParseError') event.

<a name='F-Bb-Csv-ParseErrorAction-ThrowException'></a>
### ThrowException `constants`

##### Summary

Throws an exception.

<a name='T-Bb-Csv-Events-ParseErrorEventArgs'></a>
## ParseErrorEventArgs `type`

##### Namespace

Bb.Csv.Events

##### Summary

Provides data for the [ParseError](#M-CsvReader-ParseError 'CsvReader.ParseError') event.

<a name='M-Bb-Csv-Events-ParseErrorEventArgs-#ctor-Bb-Csv-Exceptions-MalformedCsvException,Bb-Csv-ParseErrorAction-'></a>
### #ctor(error,defaultAction) `constructor`

##### Summary

Initializes a new instance of the ParseErrorEventArgs class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| error | [Bb.Csv.Exceptions.MalformedCsvException](#T-Bb-Csv-Exceptions-MalformedCsvException 'Bb.Csv.Exceptions.MalformedCsvException') | The error that occured. |
| defaultAction | [Bb.Csv.ParseErrorAction](#T-Bb-Csv-ParseErrorAction 'Bb.Csv.ParseErrorAction') | The default action to take. |

<a name='F-Bb-Csv-Events-ParseErrorEventArgs-_action'></a>
### _action `constants`

##### Summary

Contains the action to take.

<a name='F-Bb-Csv-Events-ParseErrorEventArgs-_error'></a>
### _error `constants`

##### Summary

Contains the error that occured.

<a name='P-Bb-Csv-Events-ParseErrorEventArgs-Action'></a>
### Action `property`

##### Summary

Gets or sets the action to take.

<a name='P-Bb-Csv-Events-ParseErrorEventArgs-Error'></a>
### Error `property`

##### Summary

Gets the error that occured.

<a name='T-Bb-Csv-CsvReader-RecordEnumerator'></a>
## RecordEnumerator `type`

##### Namespace

Bb.Csv.CsvReader

##### Summary

Supports a simple iteration over the records of a [CsvReader](#T-CsvReader 'CsvReader').

<a name='M-Bb-Csv-CsvReader-RecordEnumerator-#ctor-Bb-Csv-CsvReader-'></a>
### #ctor(reader) `constructor`

##### Summary

Initializes a new instance of the [RecordEnumerator](#T-RecordEnumerator 'RecordEnumerator') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reader | [Bb.Csv.CsvReader](#T-Bb-Csv-CsvReader 'Bb.Csv.CsvReader') | The [CsvReader](#T-CsvReader 'CsvReader') to iterate over. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | `reader` is a `null`. |

<a name='F-Bb-Csv-CsvReader-RecordEnumerator-_current'></a>
### _current `constants`

##### Summary

Contains the current record.

<a name='F-Bb-Csv-CsvReader-RecordEnumerator-_currentRecordIndex'></a>
### _currentRecordIndex `constants`

##### Summary

Contains the current record index.

<a name='F-Bb-Csv-CsvReader-RecordEnumerator-_reader'></a>
### _reader `constants`

##### Summary

Contains the enumerated [CsvReader](#T-CsvReader 'CsvReader').

<a name='P-Bb-Csv-CsvReader-RecordEnumerator-Current'></a>
### Current `property`

##### Summary

Gets the current record.

<a name='P-Bb-Csv-CsvReader-RecordEnumerator-System#Collections#IEnumerator#Current'></a>
### System#Collections#IEnumerator#Current `property`

##### Summary

Gets the current record.

<a name='M-Bb-Csv-CsvReader-RecordEnumerator-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CsvReader-RecordEnumerator-MoveNext'></a>
### MoveNext() `method`

##### Summary

Advances the enumerator to the next record of the CSV.

##### Returns

`true` if the enumerator was successfully advanced to the next record, `false` if the enumerator has passed the end of the CSV.

##### Parameters

This method has no parameters.

<a name='M-Bb-Csv-CsvReader-RecordEnumerator-Reset'></a>
### Reset() `method`

##### Summary

Sets the enumerator to its initial position, which is before the first record in the CSV.

##### Parameters

This method has no parameters.

<a name='T-Bb-MultiCsv-Token'></a>
## Token `type`

##### Namespace

Bb.MultiCsv

##### Summary

Enum describing the whole token of geodata-1-v3 specifications.

<a name='F-Bb-MultiCsv-Token-EOF'></a>
### EOF `constants`

##### Summary

The EOF

<a name='F-Bb-MultiCsv-Token-None'></a>
### None `constants`

##### Summary

The none

<a name='F-Bb-MultiCsv-Token-UNKNOWN'></a>
### UNKNOWN `constants`

##### Summary

Case unknown token

<a name='T-Bb-Csv-ValueTrimmingOptions'></a>
## ValueTrimmingOptions `type`

##### Namespace

Bb.Csv

##### Summary

Value trimming options

<a name='F-Bb-Csv-ValueTrimmingOptions-All'></a>
### All `constants`

##### Summary

All

<a name='F-Bb-Csv-ValueTrimmingOptions-None'></a>
### None `constants`

##### Summary

The none

<a name='F-Bb-Csv-ValueTrimmingOptions-QuotedOnly'></a>
### QuotedOnly `constants`

##### Summary

The quoted only

<a name='F-Bb-Csv-ValueTrimmingOptions-UnquotedOnly'></a>
### UnquotedOnly `constants`

##### Summary

The unquoted only
