import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import CloneOfPDFViewerODC_PDFViewrReactive_BinaryPDF_mvcModel from "./CloneOfPDFViewerODC.PDFViewrReactive.BinaryPDF.mvc$model.js";
import XMLPrettify_XMLPrettify_XMLPrettify_mvcModel from "./XMLPrettify.XMLPrettify.XMLPrettify.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FileStruct", "fileStructIn", "FileStruct", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_a158c76eb93396680623c04244f48b6cStructure());
}, false, ST_a158c76eb93396680623c04244f48b6cStructure), 
this.attr("_fileStructInDataFetchStatus", "_fileStructInDataFetchStatus", "_fileStructInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("XML_Text", "xML_TextIn", "XML_Text", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_xML_TextInDataFetchStatus", "_xML_TextInDataFetchStatus", "_xML_TextInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
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
if("FileStruct" in inputs) {
this.variables.fileStructIn = inputs.FileStruct;
if("_fileStructInDataFetchStatus" in inputs) {
this.variables._fileStructInDataFetchStatus = inputs._fileStructInDataFetchStatus;
}

}

if("XML_Text" in inputs) {
this.variables.xML_TextIn = inputs.XML_Text;
if("_xML_TextInDataFetchStatus" in inputs) {
this.variables._xML_TextInDataFetchStatus = inputs._xML_TextInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


