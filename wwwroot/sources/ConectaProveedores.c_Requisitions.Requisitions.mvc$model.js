import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_mvcModel from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal.mvc$model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_mvcModel from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Internal_OldRequisitions.mvc$model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_mvcModel from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.mvc$model.js";


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsActiveDEV_NewVersionScreenDownloads", "isActiveDEV_NewVersionScreenDownloadsOut", "IsActiveDEV_NewVersionScreenDownloads", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
isActiveDEV_NewVersionScreenDownloadsOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new VariablesRecord(new VariablesRecord.RecordClass({
getSettingsDataAct: OS$DataTypes.ImmutableBase.getData(str)
}));
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
Model._hasValidationWidgetsValue = (((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_mvcModel.hasValidationWidgets) || ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_OldRequisitions_mvcModel.hasValidationWidgets) || ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


