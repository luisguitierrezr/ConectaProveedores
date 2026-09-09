import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Link as OSWidgets$Link, Image as OSWidgets$Image, Text as OSWidgets$Text, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Interaction_Search_mvc_view from "./OutSystemsUI.Interaction.Search.mvc$view.js";
import { createElement } from "react";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, Navigation as OS$Navigation, DataConversion as OS$DataConversion, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import { ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import { SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.mvc$controller.js";

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
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: (auto);"
},
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
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
classes: "ThemeGrid_Width10"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_Search_mvc_view, {
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
uuid: "6",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "wcag-hide-text",
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("D85bULgJ60mZPc+7qVaclA#Value", "Search input"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Search*/ 8,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("saTMMn2skEqAwtkBgu2M2w#ValueExpression.2420395.1", "Name"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_RequisitionSearch(value);
}),
_idProps: {
service: idService,
name: "Input_Nothing2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_RequisitionSearch())]
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_Nothing2")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "9",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
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
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_AmountML3",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mS5RyLA5tkm2DHIT69miIw#Value", "From Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_AmountFromTextVar, function (value) {
model.variables.l_AmountFromTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_AmountML3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
InputId: idService.getId("Input_AmountML3"),
DecimalSeparator: ".",
SuffixText: "",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
RightAlign: true,
GroupSeparator: ","
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
uuid: "13",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_AmountML3"),
DebounceDelay: 1000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onDebounce$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "14",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
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
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_AmountML2",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("x7f5AbGvKky5hQFxT7fI2w#Value", "To Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_AmountToTextVar, function (value) {
model.variables.l_AmountToTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_AmountML2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
GroupSeparator: ",",
RightAlign: true,
UseNumericInput: true,
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_AmountML2"),
SuffixText: ""
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
uuid: "18",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_AmountML2"),
DebounceDelay: 1000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onDebounce$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "19",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel margin-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lcQGSmHy6ESKMtfUj74x4w#Value", "Company"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jaNOp1hK30KFZj3fAsjMMQ#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.companyAttr.descriptionAttr;
},
list: model.variables.getCompaniesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.companyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getRequisitions_CompanyId(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_CompanyId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_BankId2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCompaniesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
marginLeft: "0"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.expandFilters$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "padding: 9px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.FilterPurple.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "margin-left-s",
visible: model.getCachedValue(idService.getId("9q8_8XyliEWzJh1jsV15sw.Visible"), function () {
return (((((((((((ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()) !== (OS$BuiltinFunctions.nullIdentifier())) || ((ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_UploadDate().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo().equals(OS$BuiltinFunctions.nullDate())));
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_UploadDate();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_CompanyId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProjectId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_AmountFrom();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_AmountTo();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_RegionId();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom();
}, function () {
return ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo();
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_cerrar2.svg"),
style: "img-l",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "display-flex margin-top-base",
visible: model.variables.l_ShowFiltersVar,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Rg6s_UIiO0SIc+EJ1ciUCw#Value", "Project "))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("sGyYgLGEt0+QW18YZPY7jw#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.project_Asset_ServiceAttr.descriptionAttr;
},
list: model.variables.getProjectAssetServicesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.project_Asset_ServiceAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, ConectaProveedoresClientVariables.getRequisitions_ProjectId(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_ProjectId(value);
}),
_idProps: {
service: idService,
name: "Dropdown_BankId3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr),
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
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerProveedorFrom.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
}),
DateFormat: "DD/MM/YYYY",
ShowTodayButton: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerFrom$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerProveedorFrom",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-2percent 2percent",
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
mandatory: false,
targetWidget: "Input_PaymentDate2",
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("B5dCvx8qaEmRtx6u2SpZ+g#Value", "Creation date from"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
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
uuid: "35",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("UqLI7NpUVUeJ5iudyga6TA#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateFrom(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom())]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2",
marginLeft: "0"
},
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DateFormat: "DD/MM/YYYY",
ShowTodayButton: true,
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerProveedorTo.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerTo$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerProveedorTo",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
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
targetWidget: "Input_PaymentDate3",
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("TNdHku8U2UGf3L8RUVQIeQ#Value", "Creation date to"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
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
uuid: "42",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("f0wNLwPNRESL2Wh11cKK5g#ValueExpression.65921.1", "All"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo(), function (value) {
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateTo(value);
}),
_idProps: {
service: idService,
name: "Input_PaymentDate3"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo())]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo())]
})))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getRequisitionsForUploadAggr.isDataFetchedAttr, false, this, function () {
return [$if(((((((((((model.variables.getRequisitionsForUploadAggr.listOut.isEmpty && (ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId() === OS$BuiltinFunctions.nullIdentifier())) && (ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId() === OS$BuiltinFunctions.nullIdentifier())) && ConectaProveedoresClientVariables.getRequisitions_UploadDate().equals(OS$BuiltinFunctions.nullDate())) && ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0))) && ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))) && ConectaProveedoresClientVariables.getRequisitions_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom().equals(OS$BuiltinFunctions.nullDate())) && ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo().equals(OS$BuiltinFunctions.nullDate())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("rRVwRSAQ50e1ypsCqsuH3Q#Value", "There are no billing requisitions available associated with your role for invoice uploading."))],
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if((model.variables.getRequisitionsForUploadAggr.listOut.isEmpty && (((((((((((ConectaProveedoresClientVariables.getRequisitions_RequisitionsStatusId()) !== (OS$BuiltinFunctions.nullIdentifier())) || ((ConectaProveedoresClientVariables.getRequisitions_ApprovalStatusId()) !== (OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_UploadDate().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_RegionId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateFrom().equals(OS$BuiltinFunctions.nullDate()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProveedorFilter_UploadDateTo().equals(OS$BuiltinFunctions.nullDate())))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
style: "font-size: 16px;"
},
text: [$text(getTranslation("Jx4ATbZqGkuFiGcNIL776w#Value", "No results were found with the selected filters."))],
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("41QVfyFHxkm6WGYcLvWn4w#Value", "Clear filters"))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setColumnVisiblityOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "OpenPopupLink"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-semi-bold italic",
text: [$text(getTranslation("o3glw+xt2EO5rbDS2rv9Zg#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
alias: "11"
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
source: model.variables.getRequisitionsForUploadAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresRequisitionsGetRequisitions"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Requisition.Name",
style: "donotshow",
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("xq_onh1MqkqshPxH6ZFxig#Value", "Name"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Project_Asset_Service.Description",
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("r_HrpcPiX0Spno_5LSnJpg#Value", "Project"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "Requisition.TotalAmount",
style: "donotshow",
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("NKVnkjCH0UaIj8CubfcxuQ#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("7jYAvOdRa0Oyl8RYN2Gv4Q#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: left;"
},
sortAttribute: "Company.RFC",
style: "text-align-center",
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("227GAFXzEE6_n_GOa9PnfQ#Value", "Company"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
style: "margin-top: 2px;"
},
gridProperties: {
classes: "OSFillParent"
},
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "66"
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
i_Text: model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr),
i_NChar: 20
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
uuid: "67",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr)]
}, $if(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "70",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 0px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_balance_detalles.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("mWg8TmgPP0SERPRYCfp5lQ#Value", "Advance Pay Without Invoice"))];
})
},
_dependencies: []
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 30,
i_Text: model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr)
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
uuid: "73",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("xM4dEKFzbU6FpGOmeX4RAg.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "83",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
}),
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(true, {
dataType: OS$DataTypes.DataTypes.Boolean
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_UploadBlue.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("jFLZXHaoTUGGFj0d9yFEyQ#Value", "Upload Invoices"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr)]
})))];
}, callContext, idService, "3_0")
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TableName: idService.getId("ConectaProveedoresRequisitionsGetRequisitions"),
PopupBtnId: idService.getId("OpenPopupLink"),
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetRequisitionsVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
passColumnObj$Action: function (columnJSONIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.columnTogglerPassColumn$Action(columnJSONIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "86",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarGetRequisitionsVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsForUploadAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar,
TotalCount: model.variables.getRequisitionsForUploadAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr)
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
uuid: "87",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, {
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
},
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "88",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "89"
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
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
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
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_RequisitionUploadInv_Internal",
functionKey: "0a794fe5-0ad2-4472-94cb-df958caf2f7c",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionUploadInv_Internal",
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
return [OutSystemsUI_Interaction_Search_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view];
};


return ELEM;
};

export default componentFactory()
