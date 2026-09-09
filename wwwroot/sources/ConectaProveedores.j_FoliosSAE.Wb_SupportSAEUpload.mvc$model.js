import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_187912d0df64c67be181be3d4f7af5f3, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";

class GetSupplierUsersByUserIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_187912d0df64c67be181be3d4f7af5f3));
}
static fromStructure(str) {
return new GetSupplierUsersByUserIdAggrRec(new GetSupplierUsersByUserIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierUsersByUserIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ErrorMsg", "errorMsgVar", "ErrorMsg", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("HasChanged", "hasChangedVar", "HasChanged", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetSupplierUsersByUserId", "getSupplierUsersByUserIdAggr", "GetSupplierUsersByUserId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierUsersByUserIdAggrRec());
}, true, GetSupplierUsersByUserIdAggrRec)
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
Model._hasValidationWidgetsValue = ((ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


