import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Form as OSWidgets$Form, Label as OSWidgets$Label, Switch as OSWidgets$Switch, Dropdown as OSWidgets$Dropdown, Input as OSWidgets$Input, TextArea as OSWidgets$TextArea, List as OSWidgets$List, Text as OSWidgets$Text, Button as OSWidgets$Button, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Image as OSWidgets$Image, ListItem as OSWidgets$ListItem, Checkbox as OSWidgets$Checkbox, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { SE_contractFileType as ConectaProveedores_staticEntities_contractFileType, SE_contractStatus as ConectaProveedores_staticEntities_contractStatus, SE_color as ConectaProveedores_staticEntities_color, SE_size as ConectaProveedores_staticEntities_size, SE_orderRetentionType as ConectaProveedores_staticEntities_orderRetentionType, SE_currency as ConectaProveedores_staticEntities_currency, SE_accountingDataType as ConectaProveedores_staticEntities_accountingDataType, SE_orderStatus as ConectaProveedores_staticEntities_orderStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$view.js";
import { transformTime$Action as ConectaProveedoresController$transformTime$Action } from "./ConectaProveedores.controller.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import OutSystemsUI_Adaptive_Columns4_mvc_view from "./OutSystemsUI.Adaptive.Columns4.mvc$view.js";
import ConectaProveedores_e_Orders_wb_OrderDetail_3Attachments_mvc_view from "./ConectaProveedores.e_Orders.wb_OrderDetail_3Attachments.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderReject_Popup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-18px",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6);"
},
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
name: "ApprovedFromTheUserArea"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("tbJsnHWoPUu3z11pMTcR4Q#Value", "Approval from the user area"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_OnChange$Action(ConectaProveedores_staticEntities_contractFileType.advancePayment, controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isApprovalFromUserAreaAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isApprovalFromUserAreaAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsApprovalFromUserArea"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), $if(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isApprovalFromUserAreaAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pkmXR7bx9ES2NxBwo45TSQ#ValueExpression.-2072364156.1", "Select the approval type"),
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: var(--space-xs);"
},
labels: function (elem) {
return elem.specialPostDeliveryAuthorizationAttr.labelAttr;
},
list: model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut,
mandatory: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isApprovalFromUserAreaAttr,
style: "dropdown",
values: function (elem) {
return elem.specialPostDeliveryAuthorizationAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.orderAccountingOut.specialPostDeliveryAuthIdAttr, function (value) {
model.variables.getAccountingDataDataAct.orderAccountingOut.specialPostDeliveryAuthIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_SpecialPostDeliveryAuthId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Project"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mk3WKi_bIUqWGcPhnTgtVg#Value", "Project/Asset/Service"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DSQmtk16XkeX0WzoKvZZpw#ValueExpression.-895550020.1", "Select Project/Asset/Service"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.project_Asset_ServiceAttr.descriptionAttr;
},
list: model.variables.getProjectAssetServicesAggr.listOut,
mandatory: true,
style: "dropdown ",
values: function (elem) {
return elem.project_Asset_ServiceAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_projectassetservice"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceIdAttr.equals(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceIdAttr.equals(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr),
targetWidget: "Input_ProjectAssetService",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr, model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr)
}, $text(getTranslation("DZu1mCdsWES1JyCuwyCvaA#Value", "Project/Asset/Service"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceIdAttr.equals(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr),
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dc38JgBkQEyOk8zPYM2KOQ#ValueExpression.1196787136.1", "Project/Asset/Service"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectAssetServiceAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ProjectAssetService"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr, model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-textarea margin-bottom-m",
visible: true,
_idProps: {
service: idService,
name: "Desc"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_ProjectDescription",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2ZU1x2H9s0eVFy323qePqA#Value", "Project Description"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
prompt: model.getCachedValue(idService.getId("TextArea_ProjectDescription.Prompt"), function () {
return ((model.variables.l_CanEditFormVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("g6himkgJEECdwGyQ2VnflQ#ValueExpression.13307189.1", "Project Description")) : (""));
}, function () {
return model.variables.l_CanEditFormVar;
}),
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectDescriptionAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.projectDescriptionAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_ProjectDescription"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "FreqPeriod"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_BusinessCategoryValue2",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1+54sL9aKkGgrWS+aaTVXA#Value", "Frequency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zAvrx_29DkWbYazoU9HlgA#ValueExpression.1933944124.1", "Frequency"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.frequencyAttr.labelAttr;
},
list: model.variables.getFrequenciesAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.frequencyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.frequencyAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.frequencyAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategoryValue2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFrequenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Period",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gUSkzO9yzkyT2IZDmWpH8Q#Value", "Period"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.periodAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.periodAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Period"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
name: "BusinessCategories"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_BusinessCategoryValue",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1zBaiSmt7Uif5TXIy05loQ#Value", "Business Value"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("G1Z9WquUvEaCCJ5YM29fkQ#ValueExpression.115155230.1", "Category"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.businessValueCategoryAttr.descriptionAttr;
},
list: model.variables.getBusinessValueCategoriesAggr.listOut,
mandatory: true,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_BusinessCategoryValueOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.businessValueCategoryAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueCategoryIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueCategoryIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategoryValue"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.l_CanEditFormVar && (!(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut.isEmpty))),
targetWidget: "Dropdown_BusinessCategorySubValue",
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("k8o+Vp_Aa0GtJ9aTmQm0Ug#Value", "Sub-Value"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZRsj3Gu02Em7l+fx4FPcxA#ValueExpression.-1326718178.1", "Subcategory"),
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut.isEmpty))),
labels: function (elem) {
return elem.businessValueSubcategoryAttr.descriptionAttr;
},
list: model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut,
mandatory: (model.variables.l_CanEditFormVar && (!(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut.isEmpty))),
style: "dropdown",
values: function (elem) {
return elem.businessValueSubcategoryAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueSubcategoryIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.businessValueSubcategoryIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategorySubValue"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr),
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
name: "Positions"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative;"
},
style: "os-boxlabel custom-list-border custom-container margin-bottom-m ",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_2u2zjOmtEuZ_jBp4o0Fwg#Value", "Positions"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderMainItemsByOrderMainIdAggr.listOut,
style: "list list-group overflow-visible margin-top-xs",
tag: "div",
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceUsageAttr.keyAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.descriptionAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.cCAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.invoiceUsageIdAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-style: italic;"
},
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "font-style: normal; font-weight: normal;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-weight: bold;"
},
text: [$text(getTranslation("DsDmOAMWf0q0mTcUVRet9g#Value", "Position"))],
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr, function (value) {
model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.positionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DocumentNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RvCiCUjyJkWgp4Q7LntvHQ#Value", "Main account"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.cCAttr, function (value) {
model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.cCAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DocumentNumber2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7fhE56TbMESSw63oMgUpeQ#Value", "Accounting account name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.descriptionAttr, function (value) {
model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).accountingAccounts_ServiceTypeAttr.descriptionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DocumentNumber3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_InvoiceUsageItem",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-weight: bold;"
},
text: [$text(getTranslation("QuElQFHsh0WolPlztUilfg#Value", "Invoice Usage"))],
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yt1MyFJKWUiL8fovL02RyA#ValueExpression.-177324370.1", "Invoice Usage"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.invoiceUsageAttr.descriptionAttr;
},
list: model.variables.getInvoiceUsagesAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_InvoiceUsageItemOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.invoiceUsageAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.invoiceUsageIdAttr, function (value) {
model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.invoiceUsageIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_InvoiceUsageItem"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("kLCz136S6k6pZad84UNLyA#Value", "Key to use"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceUsageAttr.keyAttr, function (value) {
model.variables.getOrderMainItemsByOrderMainIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceUsageAttr.keyAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DocumentNumber4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr)
}))))];
}, callContext, idService, "7")
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsByOrderMainIdAggr.dataFetchStatusAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Payment"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_BusinessCategoryValue3",
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("w5VKeqNROUeWREIeauefrA#Value", "Payment Options"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("uuwXg4kdtUWjrP2volFvfA#ValueExpression.1269271675.1", "Payment Method"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentOptionsAttr.descriptionAttr;
},
list: model.variables.getPaymentOptionsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.paymentOptionsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentOptionsIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentOptionsIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategoryValue3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_BusinessCategorySubValue2",
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ry0tp3hVokus1Gv0O4JJuQ#Value", "Payment Ways"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("UH22_7hpXU2oWoi_h96+AA#ValueExpression.-391766394.1", "Payment Term"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return ((("(" + elem.paymentWaysAttr.codeAttr) + ") ") + elem.paymentWaysAttr.descriptionAttr);
},
list: model.variables.getPaymentWaysAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.paymentWaysAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentWaysIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentWaysIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategorySubValue2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentWaysAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
name: "BaseDate"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "64",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align  flex-wrap margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasBaseDateAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasBaseDateAttr = value;
}),
_idProps: {
service: idService,
name: "SwitchIsApprovedFromTheUserArea2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s ",
text: [$text(getTranslation("6u7eePWkPk2KrlwfVtCC0Q#Value", "Has Base Date"))],
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_PaymentMethodId5",
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("PdBp6lG3DUuTsm4S9iwdSQ#Value", "Payment Method"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+xHqHzwP50KFO3tMnh+RlQ#ValueExpression.722673599.1", "Select payment method"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentMethodsAttr.descriptionAttr;
},
list: model.variables.getPaymentMethodsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.paymentMethodsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentMethodIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentMethodIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentMethodId5"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentMethodsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentMethodsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getPaymentMethodsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasBaseDateAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Contract"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3KwWao3REkWH1rdmqwMX3Q#Value", "Has Contract"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("LPWHPTx6Dku9titgLy85yg#ValueExpression.-1137089512.1", "Has Contract"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.contractStatusAttr.labelAttr;
},
list: model.variables.getContractStatusesAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.contractStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_ContractStatus"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getContractStatusesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending),
targetWidget: "Input_DateOfCommitment9",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("hLVwEbMjCk6lEBw5a0sP3A#Value", "Date of commitment"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending),
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lH+dSbcEe0mzm1EmXJ_cMw#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.dateOfCommitmentAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.dateOfCommitmentAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment9"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}))), $if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes) || (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-container margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yUYseSzChkSUiyIfDgWm4A#Value", "Contract"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Contract2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Input_DateOfCommitment2",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("C7by6Pu8OUGGpEUg7b_BUA#Value", "Contract Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("s1NxrwDnGkq5+Jkdocf6ZQ#ValueExpression.-619520489.1", "Contract Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractNumberAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ContractNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FilesMaxSize: 20971520,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rlH_L+ox1EmLEgt4ql8NBw#Value.-502303438.1", "Contract"),
i_Valid: model.variables.getOrderContractDataDataAct.o_ContractFileOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_File: model.getCachedValue(idService.getId("5Czo+3fulUSResv8uGvV9Q.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.filenameAttr;
}, function () {
return model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_IsMandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_StorageId: model.variables.getOrderContractDataDataAct.o_ContractFileOut.orderFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_IsEnabled: (model.variables.l_CanEditFormVar || model.variables.l_CanUploadContractVar)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, true, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, true, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "86",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), $if(((model.variables.l_CanUploadContractVar && (!(model.variables.l_CanEditFormVar))) && !(OS$DataTypes.areBinaryNulls(model.variables.getOrderContractDataDataAct.o_ContractFileOut.binaryAttr, OS$BuiltinFunctions.nullBinary()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsSavingContractFileVar)),
gridProperties: {
classes: "ThemeGrid_Width6"
},
isDefault: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveContractFile$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
name: "SaveContract"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uzUrDTtH80OuCnQW2TmDMA#Value", "Save Contract File"))))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "Dates"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Input_DateOfCommitment2",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("ZugKHhatj0m7IuAP_HP7IQ#Value", "Date of Vigency"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3Vs9sFkjD0WWPST+hvchOQ#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment2"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Input_DateOfCommitment3",
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("HZWxqoelbEmcacKqXwiu9g#Value", "End Date of Vigency"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rja7HB5xPUSHt_SlWj6Hyg#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment3"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("jpVA+eqvLk+zzST5gsJZDw.Value"), function () {
return (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("su6o67KlCE6Eb++xNd880g#ValueExpression.-490867311.1", "Time of Commitment: ") + (((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr.equals(OS$BuiltinFunctions.nullDate()) || (ConectaProveedoresController$transformTime$Action(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr, callContext).outputOut === "0"))) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("su6o67KlCE6Eb++xNd880g#ValueExpression.763905514.1", "Undetermined")) : (ConectaProveedoresController$transformTime$Action(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr, callContext).outputOut)));
}, function () {
return model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.endBaseDateAttr;
}, function () {
return model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.startBaseDateAttr;
}),
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width1"
},
mandatory: false,
targetWidget: "Input_ContractAmount",
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("n8gILn_OsEqFbs0xAKIkXg#Value", "Import Total Price"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractAmountAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ContractAmount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true,
GroupSeparator: ",",
PrefixText: "",
SuffixText: "",
InputId: idService.getId("Input_ContractAmount"),
RightAlign: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "105",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_ContractTarif",
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IAcMhac2+0OKz8nGr5tQ0g#Value", "Tarif"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractTarifAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractTarifAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ContractTarif"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
InputId: idService.getId("Input_ContractTarif"),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
RightAlign: true,
SuffixText: "",
GroupSeparator: ",",
PrefixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "110",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
name: "OrdersContract"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_OrdersContract",
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("N0_1agCop02iw9SCDNrZtA#Value", "Orders-Contract"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 2000,
prompt: "72001019041,72011018092,72005628311,72018763421,...",
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.ordersContractAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.ordersContractAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_OrdersContract"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
name: "Attachfiles"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.l_CanEditFormVar, false, this, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FilesMaxSize: 20971520,
i_IsEnabled: model.variables.l_CanEditFormVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, false, true, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "115",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
dropArea: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel card custom-upload",
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("wqiYZ_Vs9key080cxSjGUg#Value", "Attach Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: model.getCachedValue(idService.getId("hmU5JLrWlUSdT_IY_7ayug.Style"), function () {
return ((model.variables.l_CanEditFormVar) ? ("text-neutral-9") : ("text-neutral-7"));
}, function () {
return model.variables.l_CanEditFormVar;
}),
text: [$text(getTranslation("hmU5JLrWlUSdT_IY_7ayug#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderContractDataDataAct.o_AttachFilesListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSInline"
},
style: "margin-right-s margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral3,
Size: ConectaProveedores_staticEntities_size.small
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "123",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: var(--color-third); !important"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "125",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrentRowNumber(callContext.iterationContext), false, false, true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr)]
}))];
}, callContext, idService, "12")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)]
}))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("bT0mM_6e9kGUROdAaRCEig.style"), function () {
return ((model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.isEmpty) ? ("top: 10px;") : ("top: 12px;"));
}, function () {
return model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.isEmpty;
})
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel card custom-upload",
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uirf7oSgQU+UcP1vFMcggQ#Value", "Attach Files"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderContractDataDataAct.o_AttachFilesListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSInline"
},
style: "margin-right-s margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral3,
Size: ConectaProveedores_staticEntities_size.small
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "134",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: var(--color-third); !important"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "136",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrentRowNumber(callContext.iterationContext), false, false, true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr)]
}))];
}, callContext, idService, "13")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)]
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderContractDataDataAct.o_AttachFilesListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.tarifAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.endBaseDateAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_o_AttachFilesList",
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ATA1diP0vU2b+gazmLIvFg#Value", "Nombre Del Anexo"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 200,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_o_AttachFilesList"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_DateOfCommitment4",
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ffu6FaPc70SK2J+f3oaD1Q#Value", "Date of Vigency"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: true,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("2INc7PMrs0eg0CHNtiWQVQ#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.startBaseDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_DateOfCommitment5",
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QlxoTI03+0mLX5cttyTKnw#Value", "End Date of Vigency"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: true,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3s+Nz+7MMUaoVRnDOAZu4w#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.endBaseDateAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.endBaseDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment5"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "ThemeGrid_Width1"
},
mandatory: true,
targetWidget: "Input_Amount",
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aE_gzH6NKUCuE7P6TH_s8g#Value", "Precio"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Amount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
RightAlign: true,
PrefixText: "",
GroupSeparator: ",",
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
UseNumericInput: true,
InputId: idService.getId("Input_Amount"),
AlwaysShowDecimalDigits: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "159",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Tarif",
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("HyPoxF71g06jYZgurMd76Q#Value", "Tarif"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.tarifAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.tarifAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Tarif"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlwaysShowDecimalDigits: true,
SuffixText: "",
PrefixText: "",
DecimalSeparator: ".",
RightAlign: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
InputId: idService.getId("Input_Tarif")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "164",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fHUhqG75gkKW+bZnpoOOZw#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KP5wHHOVO0exuMmu7pnXHQ#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.paymentTermsIdAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.paymentTermsIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Supplier3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))))];
}, callContext, idService, "15")
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)]
})), $if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Valid: model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFilesListDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("AHmIDhzYmEGt9Nk4_QCT9w#Value.1873836557.1", "Proof Of Foreign Residence"),
i_File: model.getCachedValue(idService.getId("U2DqzmW0M0yrJHyep_wF1Q.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.filenameAttr;
}, function () {
return model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFilesListDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getOrderFilesListDataAct.o_ProofOfForeignResidenceOut.orderFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFilesListDataAct.dataFetchStatusAttr),
i_IsMandatory: false,
i_IsEnabled: model.variables.l_CanEditFormVar,
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "170",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "172",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align  flex-wrap margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isRetentionAppliedAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isRetentionAppliedAttr = value;
}),
_idProps: {
service: idService,
name: "SwitchIsApprovedFromTheUserArea4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s ",
text: [$text(getTranslation("Xt01o9URu0udATIldkBekg#Value", "Is Retention applied"))],
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isRetentionAppliedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("I+Tg1I70yke47XcvTpeivQ#Value", "Retention rate"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CReBRnUDz0+3fFHkpXZdeg#ValueExpression.483680482.1", "Retention Rate"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.orderRetentionTypeAttr.labelAttr;
},
list: model.variables.getOrderRetentionTypesAggr.listOut,
mandatory: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isRetentionAppliedAttr,
style: "dropdown",
values: function (elem) {
return elem.orderRetentionTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.orderRetentionTypeIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.orderRetentionTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Supplier2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderRetentionTypesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
})];
}),
column3: new Widget.PlaceholderContent(function () {
return [$if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.orderRetentionTypeIdAttr === ConectaProveedores_staticEntities_orderRetentionType.other), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.orderRetentionTypeIdAttr === ConectaProveedores_staticEntities_orderRetentionType.other),
targetWidget: "Input_Retention",
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("sEvG3ljqiEefHJIOaEXwBA#Value", "Retention"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedEvents: {
onKeyUp: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_RetentionOnChange$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.orderRetentionTypeIdAttr === ConectaProveedores_staticEntities_orderRetentionType.other),
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Retention"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_Retention"),
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
DecimalSeparator: ".",
SuffixText: "%",
RightAlign: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "182",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderRetentionTypesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderRetentionTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.retentionRateAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.orderRetentionTypeIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isRetentionAppliedAttr)]
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "DepositInsuranceAndAdvanced"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); margin-top: 10px;"
},
style: "os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
name: "Deposit"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8JdCK2XILUK3iLcHzuxd9w#Value", "Deposit"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_OnChange$Action(ConectaProveedores_staticEntities_contractFileType.deposit, controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasDepositAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasDepositAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Deposit2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasDepositAttr && (model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.length < 3)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr, model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasDepositAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderContractDataDataAct.o_ContractDepositListOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext), true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (model.variables.l_CanEditFormVar && ((model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext)) !== (0))),
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.isForVendorUploadAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.isForVendorUploadAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}), $text(getTranslation("6vOrTXLeuUS+IltZtJoDCg#Value", " Request the supplier to upload the corresponding document"))), createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "197",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Dropdown_DepositType2",
_idProps: {
service: idService,
uuid: "199"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("jYJX+XK9E0ijNrfHqrBZEg#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.depositTypeAttr.labelAttr;
},
list: model.variables.getDepositTypesAggr.listOut,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_DepositTypeOnChange$Action(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.depositTypeIdAttr, model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.depositTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.depositTypeIdAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.depositTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_DepositType2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDepositTypesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Input_Deposit_Amount2",
_idProps: {
service: idService,
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("1htGxcFwCUqTgpsE9GuiHg#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Deposit_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SuffixText: "",
InputId: idService.getId("Input_Deposit_Amount2"),
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true,
GroupSeparator: ",",
DecimalSeparator: ".",
PrefixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "204",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "205"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Dropdown_Deposit_Currency2",
_idProps: {
service: idService,
uuid: "206"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("MsIzyJCnpEGwLDCUYeZKkw#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Deposit_Currency2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column4: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("it_HKQtUREeKeFIM3VrCeg#Value.926364987.1", "Document"),
i_File: model.getCachedValue(idService.getId("lvomxY4Cp0+RKOB0e+CD+w.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr;
return rec;
}();
}, function () {
return model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr;
}, function () {
return model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditFormVar,
i_FilesMaxSize: 20971520,
i_Valid: model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_IsMandatory: false
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "209",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.depositTypeIdAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.depositTypeIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.isForVendorUploadAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})];
}, callContext, idService, "19")
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6);"
},
style: "os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
name: "Insurance"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "211"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NBGbYsmOwEO8cwTxacfV7w#Value", "Insurance"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_OnChange$Action(ConectaProveedores_staticEntities_contractFileType.insurance, controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasInsuranceAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasInsuranceAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Insurance2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, true, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasInsuranceAttr && (model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.length < 4)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "213"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr, model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasInsuranceAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "215"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext), false, false, false, true, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "218"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "219"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "220"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "221"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.isForVendorUploadAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.isForVendorUploadAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}), $text(getTranslation("4Mvjd4NsfUKy736lNFLYGQ#Value", " Request the supplier to upload the corresponding document"))), createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "223",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "224"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Dropdown_Insurance2",
_idProps: {
service: idService,
uuid: "225"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("5UFdBfEPE0i9jCR30XTd0Q#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.insuranceTypeAttr.labelAttr;
},
list: model.variables.getInsuranceTypesAggr.listOut,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_InsuranceTypeOnChange$Action(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.insuranceTypeIdAttr, model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.insuranceTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.insuranceTypeIdAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.insuranceTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Insurance2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "227"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Input_Insurance_Amount2",
_idProps: {
service: idService,
uuid: "228"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("VTjcd5DfSEyXRUSsFI37gQ#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Insurance_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
UseNumericInput: true,
RightAlign: true,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
SuffixText: "",
InputId: idService.getId("Input_Insurance_Amount2"),
AlwaysShowDecimalDigits: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "230",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "231"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
targetWidget: "Dropdown_Insurance_Currency2",
_idProps: {
service: idService,
uuid: "232"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("6GcUyKs340CV3L1C0vValQ#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.yes),
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr, function (value) {
model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Insurance_Currency2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column4: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "234"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: model.variables.l_CanEditFormVar,
i_FilesMaxSize: 20971520,
i_IsMandatory: false,
i_StorageId: model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wl5re6AiHE2jQD0fyWDctg#Value.926364987.1", "Document"),
i_File: model.getCachedValue(idService.getId("jaNPyHLXj0mqWfDL6PcUVg.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr;
return rec;
}();
}, function () {
return model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr;
}, function () {
return model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr),
i_Valid: model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, true, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, true, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "235",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.insuranceTypeIdAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.filenameAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.insuranceTypeIdAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).orderContractFileAttr.isForVendorUploadAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext))]
})];
}, callContext, idService, "22")
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar)]
}))];
}, function () {
return [];
}))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "236"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsMandatory: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.contractStatusAttr === ConectaProveedores_staticEntities_contractStatus.pending),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_FilesMaxSize: 20971520,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mJYQM856vkyWmI0Biv_qZA#Value.-1666281426.1", "Finance Area Autorization"),
i_File: model.getCachedValue(idService.getId("CFIcV83R+E6HN9i8d2O69g.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.filenameAttr;
}, function () {
return model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFilesListDataAct.dataFetchStatusAttr),
i_Valid: model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFilesListDataAct.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditFormVar,
i_StorageId: model.variables.getOrderFilesListDataAct.o_FinanceAuthorizationOut.orderFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFilesListDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, true, false, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, true, false, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "237",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}), $if((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.currencyIdAttr) !== (ConectaProveedores_staticEntities_currency.mXN)) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.currencyIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "238"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "margin-bottom-s"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "239",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "240",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "241"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_NegotiatedExchangeRate_Accounting",
_idProps: {
service: idService,
uuid: "242"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("24W_8DavyE2OCWek5T_fXw#Value", "Exchange Rate"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
prompt: " ",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.orderAccountingOut.negociatedExchangeRateAccAttr, function (value) {
model.variables.getAccountingDataDataAct.orderAccountingOut.negociatedExchangeRateAccAttr = value;
}),
_idProps: {
service: idService,
name: "Input_NegotiatedExchangeRate_Accounting"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InputId: idService.getId("Input_NegotiatedExchangeRate_Accounting"),
UseNumericInput: true,
PrefixText: "",
RightAlign: true,
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(5),
SuffixText: "",
AlwaysShowDecimalDigits: true,
GroupSeparator: ","
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "244",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getAccountingDataDataAct.orderAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.negotiatedExchangeRateAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "245"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: model.variables.l_CanEditFormVar,
i_Valid: model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_IsMandatory: true,
i_File: model.getCachedValue(idService.getId("++HbY47HG0CZGj1IlSG7fg.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.filenameAttr;
}, function () {
return model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_FilesMaxSize: 20971520,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kHIEmzSal0qDAsflEWL_sQ#Value.447611511.1", "Evidence")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, true, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, false, true, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "246",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.orderAccountingOut.negociatedExchangeRateAccAttr)]
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getAccountingDataDataAct.orderAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.negotiatedExchangeRateAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-textarea",
visible: true,
_idProps: {
service: idService,
uuid: "247"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_ExchangeRateComment",
_idProps: {
service: idService,
uuid: "248"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("K0KTLzeYQEOTH8Yde7MsIQ#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WBgM+cYc1E2Qlc5dAMlBgg#ValueExpression.-1679915457.1", "Comment"),
style: "\"form-control\"",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getAccountingDataDataAct.orderAccountingOut.exchangeRateCommentAttr, function (value) {
model.variables.getAccountingDataDataAct.orderAccountingOut.exchangeRateCommentAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_ExchangeRateComment"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.orderFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_ExchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.orderAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.orderAccountingOut.negociatedExchangeRateAccAttr)]
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "SpecialApproval"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "251"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "252"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("p0mZ_IOMt02cZtH03GdF1Q#Value", "Special Approval"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eqjv2254P0S4BYonsjt7Fw#ValueExpression.-1137089512.1", "Has Contract"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.specialApprovalAttr.labelAttr;
},
list: model.variables.getSpecialApprovalsAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.specialApprovalAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.specialApprovalIdAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.specialApprovalIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_SpecialApproval"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSpecialApprovalsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
name: "Payments"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "255"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gA5UKO3I3Uu6XtuQUgmYJw#Value", "Payments"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "256"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getAccountingDataDataAct.isDataFetchedAttr && (!(model.variables.getAccountingDataDataAct.hasFetchErrorAttr))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); "
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "257"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "258"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Estimaciones / Iguala / Pagos Acordados"), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsActive"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), $if((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.length < 13), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, false, true, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: (model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "260"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "261"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-xs",
visible: model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "262"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align  flex-wrap margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "263"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr, function (value) {
model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr = value;
}),
_idProps: {
service: idService,
name: "SwitchIsApprovedFromTheUserArea5"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s ",
text: [$text(getTranslation("284BO5WgaEiF+bSbCbfq6g#Value", "It depends on the forms generated by the provider"))],
_idProps: {
service: idService,
uuid: "265"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "266"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "267"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible margin-bottom-s",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), false, false, false, false, true, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "269"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "270"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "271",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "272"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_AccountingDataType2",
_idProps: {
service: idService,
uuid: "273"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("iXumwwTB+kqemOpnfNe77g#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.accountingDataTypeAttr.labelAttr;
},
list: model.variables.getAccountingDataTypesAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_AccountingDataTypeOnChange$Action(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.accountingDataTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_AccountingDataType2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "275"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Number",
_idProps: {
service: idService,
uuid: "276"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5bxH04H_30i7_qjPT4YCjA#Value", "Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Number"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "278"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "279"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_DependentFoliosText",
_idProps: {
service: idService,
uuid: "280"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hjQaQ3MY4kWO9CTgFUCJcQ#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 250,
prompt: model.variables.dependentFoliosTextVar,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.dependentFoliosTextVar, function (value) {
model.variables.dependentFoliosTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_DependentFoliosText"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "282"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Amount",
_idProps: {
service: idService,
uuid: "283"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QTr9AJY0dUuqxpekbIJq4A#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr))),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Amount"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
DecimalSeparator: ".",
GroupSeparator: ",",
InputId: idService.getId("Input_Estim_Equal_Agreed_Amount"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
RightAlign: true,
SuffixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "285",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.dependentFoliosTextVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "286"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "287",
alias: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "288"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_DateOfCommitment7",
_idProps: {
service: idService,
uuid: "289"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Q9L8klGQfEK0ZrvijJNerw#Value", "Fecha de Pago"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5xHXXneFoE2Mb3obC+JsIg#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment7"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "291"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_PaymentTermsId2",
_idProps: {
service: idService,
uuid: "292"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fIInr4V_xkCP0bp21cAbNA#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DBqrEGqkLkO46u6QoxW3qQ#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [$if((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr.equals(model.variables.getPaymentTermSpecialDataAct.idOut) && model.variables.getPaymentTermSpecialDataAct.isActiveOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "294"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Amount2",
_idProps: {
service: idService,
uuid: "295"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dD1DRu8qpE+ovLbRaxllPg#Value", "Payment Days"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr))),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.dependentFoliosTextVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})];
}, callContext, idService, "26")
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.dependentFoliosTextVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); "
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "297"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "298"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bj71s48MkEKGDds6zyD7zA#Value", "Credit Note"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_CreditNoteOut.mainAccConceptAttr.isActiveAttr, function (value) {
model.variables.getAccountingDataDataAct.o_CreditNoteOut.mainAccConceptAttr.isActiveAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsActive2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, false, false, true, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: (model.variables.getAccountingDataDataAct.o_CreditNoteOut.mainAccConceptAttr.isActiveAttr && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "300"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "301"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-s",
visible: model.variables.getAccountingDataDataAct.o_CreditNoteOut.mainAccConceptAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "302"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "303"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), false, false, false, false, false, true, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "305"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "306"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "307",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "308"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Concept_Amount5",
_idProps: {
service: idService,
uuid: "309"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vLaPxWRlSkKt3nSBTrG0Dg#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr, function (value) {
model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Concept_Amount5"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InputId: idService.getId("Input_Concept_Amount5"),
RightAlign: true,
GroupSeparator: ",",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
PrefixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "311",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align  flex-wrap margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "312"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr, function (value) {
model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr = value;
}),
_idProps: {
service: idService,
name: "SwitchApplyForRequestProject4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "margin-left-s",
value: model.getCachedValue(idService.getId("YRJfaIBzjE2gDhBuWUYA8g.Value"), function () {
return (((model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.creditNote)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pMt1X0g0UkWYfhEhJuapKQ#ValueExpression.-694153125.1", "Is used for other request")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pMt1X0g0UkWYfhEhJuapKQ#ValueExpression.-575346866.1", "Is used for current project")));
}, function () {
return model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr;
}),
_idProps: {
service: idService,
uuid: "314"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "315"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_PaymentTermsId8",
_idProps: {
service: idService,
uuid: "316"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("o9MGLG_DtkmYiN+sN2fgtw#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId8"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), $if((model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr.equals(model.variables.getPaymentTermSpecialDataAct.idOut) && model.variables.getPaymentTermSpecialDataAct.isActiveOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "318"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Amount3",
_idProps: {
service: idService,
uuid: "319"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ahx0o+xDM0SlB1eL0t0aOQ#Value", "Payment Days"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr))),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr, function (value) {
model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Amount3"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
}),
column4: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "321"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_DateOfCommitment8",
_idProps: {
service: idService,
uuid: "322"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_hvf+3S5dESSCJYFqg1G5g#Value", "Fecha para nota de crédito"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("66OL+v_BRU+gD07FALApOA#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr, function (value) {
model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment8"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr)]
})];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_CreditNoteOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})];
}, callContext, idService, "28")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); "
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "324"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "325"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nkwpVuMzbkubb_3m_tUQGQ#Value", "Voucher"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_VoucherOut.mainAccConceptAttr.isActiveAttr, function (value) {
model.variables.getAccountingDataDataAct.o_VoucherOut.mainAccConceptAttr.isActiveAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsActive3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, false, false, false, true, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: (model.variables.getAccountingDataDataAct.o_VoucherOut.mainAccConceptAttr.isActiveAttr && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "327"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "328"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-s",
visible: model.variables.getAccountingDataDataAct.o_VoucherOut.mainAccConceptAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "329"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "330"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), false, false, false, false, false, false, true, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "332"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "333"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "334",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "335"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Concept_Amount6",
_idProps: {
service: idService,
uuid: "336"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("R1I2OH5c1E6mfH8MWSAvEA#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr, function (value) {
model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Concept_Amount6"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
PrefixText: "",
UseNumericInput: true,
SuffixText: "",
InputId: idService.getId("Input_Concept_Amount6"),
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "338",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align  flex-wrap margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "339"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr, function (value) {
model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr = value;
}),
_idProps: {
service: idService,
name: "SwitchApplyForRequestProject5"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "margin-left-s",
value: model.getCachedValue(idService.getId("GP3cbUvkmkClFTYhTqSJ4w.Value"), function () {
return (((model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr === ConectaProveedores_staticEntities_accountingDataType.creditNote)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5T5fHAI+OkCKXqOok_vfwA#ValueExpression.-694153125.1", "Is used for other request")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5T5fHAI+OkCKXqOok_vfwA#ValueExpression.-575346866.1", "Is used for current project")));
}, function () {
return model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr;
}),
_idProps: {
service: idService,
uuid: "341"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "342"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_PaymentTermsId9",
_idProps: {
service: idService,
uuid: "343"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("HCw6ci01nkCka51yj_Chtg#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("y0hk09DCCEO8QfHz0Ni1jQ#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId9"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), $if((model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr.equals(model.variables.getPaymentTermSpecialDataAct.idOut) && model.variables.getPaymentTermSpecialDataAct.isActiveOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "345"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Amount4",
_idProps: {
service: idService,
uuid: "346"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KgqoeFa2h0661P4Ue_dWlw#Value", "Payment Days"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr))),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
prompt: "0",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr, function (value) {
model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Amount4"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr)]
})];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).applyForRequestProjectAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_VoucherOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})];
}, callContext, idService, "30")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); "
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "348"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "349"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LvhbephVvEWsnNnRKRtikg#Value", "Finiquito / One Payment"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_FiniquitoOut.mainAccConceptAttr.isActiveAttr, function (value) {
model.variables.getAccountingDataDataAct.o_FiniquitoOut.mainAccConceptAttr.isActiveAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsActive4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-s",
visible: model.variables.getAccountingDataDataAct.o_FiniquitoOut.mainAccConceptAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "351"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "352"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "354",
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "355"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Concept_Amount3",
_idProps: {
service: idService,
uuid: "356"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uC2pjhPqf0SM+LcKSjw54w#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr, function (value) {
model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Concept_Amount3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
RightAlign: true,
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_Concept_Amount3"),
PrefixText: "",
SuffixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "358",
alias: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "359"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_PaymentTermsId5",
_idProps: {
service: idService,
uuid: "360"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("wahXukGpnEyGAuo3uR+Jvg#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IF_hcoyX70u+d8P7AGcE9A#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId5"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), $if((model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr.equals(model.variables.getPaymentTermSpecialDataAct.idOut) && model.variables.getPaymentTermSpecialDataAct.isActiveOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "362"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Amount5",
_idProps: {
service: idService,
uuid: "363"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7vFZvqa4Q0OQ_dOUVGFMUg#Value", "Payment Days"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr))),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr, function (value) {
model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Amount5"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr)]
})];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr)]
})];
}, callContext, idService, "32")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); "
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "365"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
extendedProperties: {
style: "left: 53px;"
},
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "366"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UWUl32pgak+lpJWYJPYyQA#Value", "Anticipo"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_AnticipoOut.mainAccConceptAttr.isActiveAttr, function (value) {
model.variables.getAccountingDataDataAct.o_AnticipoOut.mainAccConceptAttr.isActiveAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsActive5"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), $if((model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.length < 6), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, false, false, false, false, false, true, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: (model.variables.getAccountingDataDataAct.o_AnticipoOut.mainAccConceptAttr.isActiveAttr && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "368"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "369"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-s",
visible: model.variables.getAccountingDataDataAct.o_AnticipoOut.mainAccConceptAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "370"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "371"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: model.variables.l_CanEditFormVar,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), false, false, false, false, false, false, false, false, true, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditFormVar),
_idProps: {
service: idService,
uuid: "373"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "374"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "375",
alias: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "376"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Concept_Amount4",
_idProps: {
service: idService,
uuid: "377"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("x32C1gKiwEWGexaW5rtaeQ#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr, function (value) {
model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Concept_Amount4"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
SuffixText: "",
RightAlign: true,
InputId: idService.getId("Input_Concept_Amount4"),
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
PrefixText: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "379",
alias: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "380"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_AccountingDataType5",
_idProps: {
service: idService,
uuid: "381"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("k9UMf7KLi0C_s4Gr2H1fAg#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.advancePaymentTypeAttr.labelAttr;
},
list: model.variables.getAdvancedPaymentTypesAggr.listOut,
mandatory: false,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_AccountingDataType5OnChange$Action(model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr, model.variables.getAccountingDataDataAct.o_FiniquitoOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.advancePaymentTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).advancePaymentTypeIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).advancePaymentTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_AccountingDataType5"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "383"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "384",
alias: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "385"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_PaymentTermsId6",
_idProps: {
service: idService,
uuid: "386"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mWDaKUGgAU2uDDg99iA7Gg#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yM6alrNG2kSXiSMPufxCTw#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditFormVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId6"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), $if((model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr.equals(model.variables.getPaymentTermSpecialDataAct.idOut) && model.variables.getPaymentTermSpecialDataAct.isActiveOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "388"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Estim_Equal_Agreed_Amount6",
_idProps: {
service: idService,
uuid: "389"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bw+6aIPh2k67FATDVTzlUA#Value", "Payment Days"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditFormVar && (!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr))),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr, function (value) {
model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Estim_Equal_Agreed_Amount6"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "391"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_DateOfCommitment6",
_idProps: {
service: idService,
uuid: "392"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("C_Vxl4ErWEaXigPaErd77Q#Value", "Fecha de Pago Pactada"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("oL2LgCV4nUWudolJ55WsWw#ValueExpression.1002767249.1", "Select a date"),
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr, function (value) {
model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment6"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.l_CanEditFormVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentDateAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermCustomDaysAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).paymentTermIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_AnticipoOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})];
}, callContext, idService, "35")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.isDependentFromFoliosAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.isActiveOut), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.idOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermSpecialDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditFormVar)]
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "394"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))), $if(((!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr) !== (ConectaProveedores_staticEntities_orderStatus.toComplement))) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr) !== (ConectaProveedores_staticEntities_orderStatus.rejected))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "395"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_wb_OrderDetail_3Attachments_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_HasntRequestDocuments: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr,
_i_HasntRequestDocumentsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
l_CanEditUserArea: model.variables.l_CanEditFormVar,
i_OrderId: model.variables.i_OrderIdIn,
_i_OrderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus),
i_HasError: ((model.variables.l_RequestDocsErrorMessageVar) !== ("")),
SupplierId: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.supplierIdAttr,
_supplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
uploadMainParent$Action: function (orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_OrderDetail_AttachmentsUploadMainParent$Action(orderRequestFilesIn, hasntRequestDocumentsIn, isValidIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "396",
alias: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "text-red",
value: model.variables.l_RequestDocsErrorMessageVar,
_idProps: {
service: idService,
uuid: "397"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "vertical-align display-flex margin-top-m justify-content-space-between margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "398"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateBack(null, null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-back white-space-nowrap",
visible: true,
_idProps: {
service: idService,
uuid: "399"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BFRoNaPrwU+DYdCtA9zMfA#Value", "Close"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (model.variables.getOrderMainByIdAggr.isDataFetchedAttr && (model.variables.l_CanEditFormVar || model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).isCurrentApproverAttr)),
_idProps: {
service: idService,
uuid: "400"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "text-align-right display-flex align-items-center",
visible: model.variables.l_CanEditFormVar,
_idProps: {
service: idService,
uuid: "401"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.variables.l_CanEditFormVar,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickSave$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn white-space-nowrap",
visible: model.variables.l_CanEditFormVar,
_idProps: {
service: idService,
uuid: "402"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1hwL2y_Z7kevSKtET+eUHw#Value", "Save"))), createElement(OSWidgets$Button, {
enabled: model.variables.l_CanEditFormVar,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
_this.validateWidget("");
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickSave$Action(true, controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary white-space-nowrap",
visible: model.variables.l_CanEditFormVar,
_idProps: {
service: idService,
uuid: "403"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Capturar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "404"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("q8Et+el5GUK+NkqyhPGlGw#Value", "Finalize Capture"))],
_idProps: {
service: idService,
uuid: "405"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "text-align-right display-flex align-items-center",
visible: (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).isCurrentApproverAttr && (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved)),
_idProps: {
service: idService,
uuid: "406"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Button, {
enabled: ((((((((((((model.variables.getAccountingDataTypesAggr.isDataFetchedAttr && model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr) && model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr) && model.variables.getCurrenciesAggr.isDataFetchedAttr) && model.variables.getDepositTypesAggr.isDataFetchedAttr) && model.variables.getFrequenciesAggr.isDataFetchedAttr) && model.variables.getInsuranceTypesAggr.isDataFetchedAttr) && model.variables.getInvoiceUsagesAggr.isDataFetchedAttr) && model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr) && model.variables.getProjectAssetServicesAggr.isDataFetchedAttr) && model.variables.getOrderMainByIdAggr.isDataFetchedAttr) && model.variables.getOrderMainItemsByOrderMainIdAggr.isDataFetchedAttr) && model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr),
extendedProperties: {
style: "width: auto;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideOrderReject_Popup$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "btn btn-decline white-space-nowrap",
visible: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).isCurrentApproverAttr,
_idProps: {
service: idService,
uuid: "407"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 20px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/TelCelNotificationsLib.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "408"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("rNt9Gl44p0++llEdMejzpA#Value", "Reject"))],
_idProps: {
service: idService,
uuid: "409"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Button, {
enabled: ((((((((((((model.variables.getAccountingDataTypesAggr.isDataFetchedAttr && model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr) && model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr) && model.variables.getCurrenciesAggr.isDataFetchedAttr) && model.variables.getDepositTypesAggr.isDataFetchedAttr) && model.variables.getFrequenciesAggr.isDataFetchedAttr) && model.variables.getInsuranceTypesAggr.isDataFetchedAttr) && model.variables.getInvoiceUsagesAggr.isDataFetchedAttr) && model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr) && model.variables.getProjectAssetServicesAggr.isDataFetchedAttr) && model.variables.getOrderMainByIdAggr.isDataFetchedAttr) && model.variables.getOrderMainItemsByOrderMainIdAggr.isDataFetchedAttr) && model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr),
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.approve$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-approve white-space-nowrap",
visible: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).isCurrentApproverAttr,
_idProps: {
service: idService,
uuid: "410"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "411"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.currentLevelAttr === model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.maxLevelAttr), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("vI9ZdURVzEeHBtlwBOLpHg#Value", "Finalize"))],
_idProps: {
service: idService,
uuid: "412"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("2Ac3Oyo1g02cYcvaeTl9pg#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "413"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base)"
},
showPopup: model.variables.showOrderReject_PopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "414"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderApprovalLevelId: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.idAttr,
_i_OrderApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_OrderId: model.variables.i_OrderIdIn,
_i_OrderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (i_IsRefreshIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideOrderReject_Popup$Action(true, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "415",
alias: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderDetailPaymentInformation",
functionKey: "f005b36c-2999-43ef-97c8-6e0adb64a087",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_OrderDetailPaymentInformation",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Adaptive_Columns2_mvc_view, ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Adaptive_Columns4_mvc_view, ConectaProveedores_e_Orders_wb_OrderDetail_3Attachments_mvc_view, ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_view];
};


return ELEM;
};

export default componentFactory()
