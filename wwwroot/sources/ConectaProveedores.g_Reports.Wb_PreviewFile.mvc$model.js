import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel from "./CloneOfPDFViewerODC.PDFViewrReactive.BinaryPDF.mvc$model.js";
import XMLPrettify_XMLPrettify_XMLPrettify_mvcModel from "./XMLPrettify.XMLPrettify.XMLPrettify.mvc$model.js";


class GetDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_xml", "o_xmlOut", "o_xml", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("o_Filename", "o_FilenameOut", "o_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("o_Binary", "o_BinaryOut", "o_Binary", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Binary", "l_BinaryVar", "l_Binary", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("l_xml", "l_xmlVar", "l_xml", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_Filename", "l_FilenameVar", "l_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_PopupToggler", "l_PopupTogglerVar", "l_PopupToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("StorageId", "storageIdIn", "StorageId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_storageIdInDataFetchStatus", "_storageIdInDataFetchStatus", "_storageIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ForceRefresh", "forceRefreshIn", "ForceRefresh", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_forceRefreshInDataFetchStatus", "_forceRefreshInDataFetchStatus", "_forceRefreshInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetData", "getDataDataAct", "GetData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetDataDataActRec());
}, true, GetDataDataActRec)
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
Model._hasValidationWidgetsValue = ((OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel.hasValidationWidgets) || XMLPrettify_XMLPrettify_XMLPrettify_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("StorageId" in inputs) {
this.variables.storageIdIn = inputs.StorageId;
if("_storageIdInDataFetchStatus" in inputs) {
this.variables._storageIdInDataFetchStatus = inputs._storageIdInDataFetchStatus;
}

}

if("ForceRefresh" in inputs) {
this.variables.forceRefreshIn = inputs.ForceRefresh;
if("_forceRefreshInDataFetchStatus" in inputs) {
this.variables._forceRefreshInDataFetchStatus = inputs._forceRefreshInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


