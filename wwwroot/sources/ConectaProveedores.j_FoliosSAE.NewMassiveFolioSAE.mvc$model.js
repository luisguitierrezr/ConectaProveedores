import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_118fe20454dd0bf1f0e6d925e7d7544bStructure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_6dc39d329f4b959722daa75bc2f62c1fStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import ConectaProveedores_d_Invoices_wb_AccSelect_mvcModel from "./ConectaProveedores.d_Invoices.wb_AccSelect.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";


class GetSupplierNameDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("SupplierName", "supplierNameOut", "SupplierName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSupplierNameDataActRec(new GetSupplierNameDataActRec.RecordClass({
supplierNameOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierNameDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("FolioQList", "folioQListVar", "FolioQList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_118fe20454dd0bf1f0e6d925e7d7544bStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_118fe20454dd0bf1f0e6d925e7d7544bStructure))), 
this.attr("NumberOfRecords", "numberOfRecordsVar", "NumberOfRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("NumberWithErrors", "numberWithErrorsVar", "NumberWithErrors", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("HelpPopup", "helpPopupVar", "HelpPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderMainID", "l_OrderMainIDVar", "l_OrderMainID", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_FolioAccData", "l_FolioAccDataVar", "l_FolioAccData", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6dc39d329f4b959722daa75bc2f62c1fStructure());
}, false, ST_6dc39d329f4b959722daa75bc2f62c1fStructure), 
this.attr("GetSupplierName", "getSupplierNameDataAct", "GetSupplierName", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierNameDataActRec());
}, true, GetSupplierNameDataActRec)
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
Model._hasValidationWidgetsValue = (((((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_wb_AccSelect_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


