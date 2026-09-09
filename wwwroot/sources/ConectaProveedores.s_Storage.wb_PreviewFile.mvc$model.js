import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord } from "./TelcelStorage.model.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel from "./CloneOfPDFViewerODC.PDFViewrReactive.BinaryPDF.mvc$model.js";
import XMLPrettify_XMLPrettify_XMLPrettify_mvcModel from "./XMLPrettify.XMLPrettify.XMLPrettify.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";

class GetStorageByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord, {
name: "Storage",
attrName: "storageAttr",
nameForJson: "Storage",
uniqueId: "b2edf193-9202-eb7e-60eb-499349388514"
}))));
}
static fromStructure(str) {
return new GetStorageByIdAggrRec(new GetStorageByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetStorageByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_PopupToggler", "l_PopupTogglerVar", "l_PopupToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("FileStruct", "fileStructVar", "FileStruct", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_a158c76eb93396680623c04244f48b6cStructure());
}, false, ST_a158c76eb93396680623c04244f48b6cStructure), 
this.attr("XML_Text", "xML_TextVar", "XML_Text", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_StorageId", "i_StorageIdIn", "i_StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", "_i_StorageIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FileSize", "i_FileSizeIn", "i_FileSize", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FileSizeInDataFetchStatus", "_i_FileSizeInDataFetchStatus", "_i_FileSizeInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_IsTagStyle", "i_IsTagStyleIn", "i_IsTagStyle", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_IsTagStyleInDataFetchStatus", "_i_IsTagStyleInDataFetchStatus", "_i_IsTagStyleInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_TagText", "i_TagTextIn", "i_TagText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_TagTextInDataFetchStatus", "_i_TagTextInDataFetchStatus", "_i_TagTextInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ExtendedClass", "i_ExtendedClassIn", "i_ExtendedClass", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ExtendedClassInDataFetchStatus", "_i_ExtendedClassInDataFetchStatus", "_i_ExtendedClassInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetStorageById", "getStorageByIdAggr", "GetStorageById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetStorageByIdAggrRec());
}, true, GetStorageByIdAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
}

}

class Model extends 
OS$Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = ((((OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel.hasValidationWidgets) || XMLPrettify_XMLPrettify_XMLPrettify_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_StorageId" in inputs) {
this.variables.i_StorageIdIn = inputs.i_StorageId;
if("_i_StorageIdInDataFetchStatus" in inputs) {
this.variables._i_StorageIdInDataFetchStatus = inputs._i_StorageIdInDataFetchStatus;
}

}

if("i_FileSize" in inputs) {
this.variables.i_FileSizeIn = inputs.i_FileSize;
if("_i_FileSizeInDataFetchStatus" in inputs) {
this.variables._i_FileSizeInDataFetchStatus = inputs._i_FileSizeInDataFetchStatus;
}

}

if("i_IsTagStyle" in inputs) {
this.variables.i_IsTagStyleIn = inputs.i_IsTagStyle;
if("_i_IsTagStyleInDataFetchStatus" in inputs) {
this.variables._i_IsTagStyleInDataFetchStatus = inputs._i_IsTagStyleInDataFetchStatus;
}

}

if("i_TagText" in inputs) {
this.variables.i_TagTextIn = inputs.i_TagText;
if("_i_TagTextInDataFetchStatus" in inputs) {
this.variables._i_TagTextInDataFetchStatus = inputs._i_TagTextInDataFetchStatus;
}

}

if("i_ExtendedClass" in inputs) {
this.variables.i_ExtendedClassIn = inputs.i_ExtendedClass;
if("_i_ExtendedClassInDataFetchStatus" in inputs) {
this.variables._i_ExtendedClassInDataFetchStatus = inputs._i_ExtendedClassInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


