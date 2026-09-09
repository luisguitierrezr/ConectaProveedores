import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression, Label as OSWidgets$Label, Input as OSWidgets$Input, Text as OSWidgets$Text, Link as OSWidgets$Link, Image as OSWidgets$Image, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, DataTypes as OS$DataTypes, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.wb_OrderDetail_1Info.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.wb_OrderDetail_1Info.mvc$controller.js";

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
style: "margin-top-xs margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary italic",
value: model.getCachedValue(idService.getId("VdT3wxgJjE6U8tzqq1Xw3g.Value"), function () {
return (((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yCFGYmMwWU+2alX_6pje0A#ValueExpression.-1153109893.1", "Imported On") + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).ordersImportRequestAttr.createdOnAttr, "dd/MM/yyyy HH:mm")) + ((!(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).ordersImportRequestAttr.updatedOnAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((((", " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yCFGYmMwWU+2alX_6pje0A#ValueExpression.1697939364.1", "Updated On")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).ordersImportRequestAttr.updatedOnAttr, "dd/MM/yyyy HH:mm"))) : ("")));
}, function () {
return model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).ordersImportRequestAttr.createdOnAttr;
}, function () {
return model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).ordersImportRequestAttr.updatedOnAttr;
}),
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m display-flex align-items-baseline",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_DocumentNumber",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NPIHBj5DoUe2chqq9M8FCQ#Value", "Order Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 10,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DocumentNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "padding-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "display-flex align-items-center",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("bU97INzOBUWshsHrN10hoQ#Value", "Order PDF"))],
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickDownloadPdf$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "align-items-flex-end display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: fill;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_pdf.svg"),
style: "full-height",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "11"
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
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_ContractNumber",
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("e6dXmY6uqEeF+HWuG2U8RQ#Value", "Contract Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 10,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.contractNumberAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.contractNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ContractNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_OrderRequest",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ufLcuuDlNEiIUuvBF7pJPQ#Value", "Order Request"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 10,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.purchaseRequisitionNumberAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.purchaseRequisitionNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_OrderRequest"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "18"
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
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PurchasingGroup",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("emnaAPLrgUGJDHtks_27Gw#Value", "Procurement Group"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 3,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.procurementGroupAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.procurementGroupAttr = value;
}),
_idProps: {
service: idService,
name: "Input_PurchasingGroup"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel non-mandatory",
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
targetWidget: "Input_Distribution",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1Uz1MLZHfE2TzxGuGDFpPw#Value", "Distribution"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NICUvDcWvkKkPQPHHFJdhw#ValueExpression.518877515.1", "COST CENTERS"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).distributionAttr.labelAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).distributionAttr.labelAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Distribution"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "25"
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
mandatory: false,
targetWidget: "Input_Company",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("MnqjmTmPf0uaSbXFqhFUzQ#Value", "Company"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 100,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Company"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
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
mandatory: false,
targetWidget: "Input_PurchasingGroup2",
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Ix4XDK+ngE6U9UsMSIZljQ#Value", "Requester"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 12,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.applicantAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.applicantAttr = value;
}),
_idProps: {
service: idService,
name: "Input_PurchasingGroup2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel non-mandatory",
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
mandatory: true,
targetWidget: "Input_Region",
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("H8d80UXPa0u7IIT0Uek+HQ#Value", "Region"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 10,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Region"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
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
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Society",
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("M9yye9WbO0qf5y60_jPySg#Value", "Society"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.externalIdAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.externalIdAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Society"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "39"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount",
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("okh2LLg+YkCMozd58l2GGA#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.tempValuesVar.totalAmountAttr, function (value) {
model.variables.tempValuesVar.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount"
},
_widgetRecordProvider: widgetsRecordProvider
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
}, $text(getTranslation("tmyKfcglYEmP2mQQdqm10A#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: false,
labels: function (elem) {
return elem.currencyAttr.codeAttr;
},
list: model.variables.getOrderByIdAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown1"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), $if(false, false, this, function () {
return [];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "46"
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
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount2",
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KDWszhTn7Eirexh9FVRKMA#Value", "Sustainability Category"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 70,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.sustainabilityCategoryAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.sustainabilityCategoryAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
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
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_IVA2",
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oeSsKjeG4EG8k2lbCiQ9Pw#Value", "Sustainability Subcategory"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 255,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.sustainabilitySubcategoryAttr, function (value) {
model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.sustainabilitySubcategoryAttr = value;
}),
_idProps: {
service: idService,
name: "Input_IVA2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderMainItemsDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrderMainItemsDataAct.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JwbL0voEs0S2vWonyME7pQ#Value", "No items to show...")))];
}, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
Orientation: ConectaProveedores_staticEntities_orientation.horizontal
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "55",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getOrderMainItemsDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("caCOl8NXU0KIvCLqttywMg#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "UMP"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jX728PnBWkilEg0Vh66_Mg#Value", "Material Code"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("w8YzkissE0uVi0c53eW6ig#Value", "Material Description"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mAGxJ2Y8nUO5HlSFkijCbg#Value", "Cost Center"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_86enIFFFEG6sKUJPabKaw#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nPqpBm+MJkOmiodqTKO99g#Value", "Price Unit"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tWgiRnOot0i94tH8_vxyxQ#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right text-align: center;"
},
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("X+q2m0Q2nEuaZH3TOcrNvg#Value", "Quantity Delivered"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("5nqZe+U1T0qwT8Xs3O7KOA#Value", "Quantity Remaining"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("iJoNYS8tzk+Pi6UvbLl0MA#Value", "Por"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("kpnuoZTL40SabzZIvvP03w#Value", "VAT Indicator"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("1S5g0c+1OU6W2bYRU0qLhQ#Value", "Total"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center"
},
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wbq91JvvZEypOctF8N9qog#Value", "Is Final Delivery")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isDeletedAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isBlockedAttr)]
}, $if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isBlockedAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "73",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_bloquear.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("3R+Hm1h4CkKEb7ScSBWhsA#Value", "Locked"))];
})
},
_dependencies: []
})];
}, function () {
return [$if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isDeletedAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "75",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_borrar.svg"),
style: "img img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("tJPt_RpHgEKfsjWg+6rL6Q#Value", "Deleted"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderUnitOfMeasureAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderUnitOfMeasureAttr,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialCodeAttr,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialDescriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialDescriptionAttr,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).costcenterAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "88",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_mosaico.svg"),
style: "margin-right-s",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Múltiple imputación"];
})
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).costcenterAttr,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).regionAttr,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("8u48pMKLX0Saaulb6M_tGg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("PP3VLUixnEyAYVh5hmImIA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr, 3, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr;
}),
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("TKmv03zCeEW8KzNGlBip1g.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr, 3, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr;
}),
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5+h9Ih88SUWEGWik7O3hlQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr.minus(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr), 3, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr;
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr;
}),
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).baseQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).baseQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vAtIndicatorAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5F8Fc83qNUuBoYfSkqMIDg.Value"), function () {
return ((OS$BuiltinFunctions.formatPercent(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr, 2, ".") + " - ") + model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vAtIndicatorAttr);
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr;
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vAtIndicatorAttr;
}),
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).baseQuantityAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("f9Li2fE6rk2F+kXOUWDI3g.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr.times(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).baseQuantityAttr))), "", 2, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr;
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr;
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).baseQuantityAttr;
}),
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isFinalDeliveredAttr)]
}, createElement(OSWidgets$Container, {
align: /*Center*/ 2,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isFinalDeliveredAttr,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr), asPrimitiveValue(model.variables.getOrderByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrderByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainItemAttr.isMultipleImputationAttr), asPrimitiveValue(model.variables.getOrderByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
MaxRecords: model.variables.maxRecordsVar,
TotalCount: OS$BuiltinFunctions.integerToLongInteger(model.variables.getOrderMainItemsDataAct.countOut),
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "112",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_OrderDetail_1Info",
functionKey: "5c71144f-c07b-4e27-8870-8bd5b33163a7",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.wb_OrderDetail_1Info",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
