import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_29dc80a5deae2388e31181e1082143cfStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Content_Accordion_mvcModel from "./OutSystemsUI.Content.Accordion.mvc$model.js";
import OutSystemsUI_Content_AccordionItem_mvcModel from "./OutSystemsUI.Content.AccordionItem.mvc$model.js";
import ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvcModel from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.mvc$model.js";


class GetInvoicesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("Invoices", "invoicesOut", "Invoices", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_29dc80a5deae2388e31181e1082143cfStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_29dc80a5deae2388e31181e1082143cfStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetInvoicesDataActRec(new GetInvoicesDataActRec.RecordClass({
invoicesOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_IsSaveAllFiles", "i_IsSaveAllFilesVar", "i_IsSaveAllFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_IsSaveSelectedFiles", "i_IsSaveSelectedFilesVar", "i_IsSaveSelectedFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("GetInvoices", "getInvoicesDataAct", "GetInvoices", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesDataActRec());
}, true, GetInvoicesDataActRec)
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
Model._hasValidationWidgetsValue = (((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Accordion_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_AccordionItem_mvcModel.hasValidationWidgets) || ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


