import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$model.js";
import OutSystemsUI_Navigation_Tabs_mvcModel from "./OutSystemsUI.Navigation.Tabs.mvc$model.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvcModel from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$model.js";
import OutSystemsUI_Navigation_TabsContentItem_mvcModel from "./OutSystemsUI.Navigation.TabsContentItem.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationBySupplier.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByUUID_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationByUUID.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByDatesRange_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationByDatesRange.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByYear_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationByYear.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByAccount_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationByAccount.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationByFile_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationByFile.mvc$model.js";
import ConectaProveedores_g_Reports_wb_documentExtrationFiles_mvcModel from "./ConectaProveedores.g_Reports.wb_documentExtrationFiles.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ActiveTab", "l_ActiveTabVar", "l_ActiveTab", true, false, OS$DataTypes.DataTypes.Text, function () {
return "0";
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new VariablesRecord(new VariablesRecord.RecordClass({
l_ActiveTabVar: OS$DataTypes.ImmutableBase.getData(str)
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
Model._hasValidationWidgetsValue = ((((((((((ConectaProveedores_a_Layouts_LayoutTopMenu_mvcModel.hasValidationWidgets || OutSystemsUI_Navigation_Tabs_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsHeaderItem_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_TabsContentItem_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationByUUID_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationByDatesRange_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationByYear_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationByAccount_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationByFile_mvcModel.hasValidationWidgets) || ConectaProveedores_g_Reports_wb_documentExtrationFiles_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


