import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Form as OSWidgets$Form, Label as OSWidgets$Label, Input as OSWidgets$Input, Switch as OSWidgets$Switch, ListItem as OSWidgets$ListItem, Dropdown as OSWidgets$Dropdown, TextArea as OSWidgets$TextArea, List as OSWidgets$List, Button as OSWidgets$Button, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_requisitionStatus as ConectaProveedores_staticEntities_requisitionStatus, SE_advancePaymentType as ConectaProveedores_staticEntities_advancePaymentType, SE_space as ConectaProveedores_staticEntities_space, SE_color as ConectaProveedores_staticEntities_color, SE_distribution as ConectaProveedores_staticEntities_distribution, SE_currency as ConectaProveedores_staticEntities_currency, SE_datePickerTimeFormat as ConectaProveedores_staticEntities_datePickerTimeFormat, SE_size as ConectaProveedores_staticEntities_size, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.mvc$view.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchSupplierDropdown.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Adaptive_Columns4_mvc_view from "./OutSystemsUI.Adaptive.Columns4.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import { ST_a158c76eb93396680623c04244f48b6cStructure, ST_1d6498da9105fbe815a7f766352917c0Structure, ST_f9f8b40f5330871047e55e068d129447Structure, RC_d2eb0d0bdf3678ac335e4faafec1c741 } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$view.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskText_mvc_view from "./InputMasks.InputMaskReactFlow.MaskText.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SearchDropdown_mvc_view from "./ConectaProveedores.y_Utils.Wb_SearchDropdown.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import BigUpload_BigUpload_wb_BigUploadSingleFile_mvc_view from "./BigUpload.BigUpload.wb_BigUploadSingleFile.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_RequisitionLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_RequisitionLogs.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_RequisitionInvoices.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_SearchSupplier_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_SearchSupplier.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_RequisitionEntra_Historic.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_ReqCancelModif_Popup.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_SelectReqRegion_Popup.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_AssignFirstApproverPopup.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_IsSpecialOrNormalWF_Popup.mvc$view.js";
import AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view from "./AutoRefreshUtils.Widget.EventExtensibilityBlock.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.RequisitionDetail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.RequisitionDetail.mvc$controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Initiative: "FSP",
ChatBotIsEnable: true
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_inicio2025.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}),
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link font-semi-bold",
text: [$text(getTranslation("9QLAggxej02bRHP3AXmzFA#Value", "Homepage"))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Dashboard", {}),
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link ",
text: [$text(getTranslation("BcWVE+qTN06J42aj7OAJ8w#Value", "Dashboard"))],
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("xI9OenfbqUalfPUqAcnaYw#Value", "Requisitions"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("3lPjBjSQ0kKjkkgiJNFwew#Value", "Requisition Detail"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "custom-columns",
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "17",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("p1DiWgDBKUGpytnteVAzFA#Value", "New Requisition"))],
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("gsrCyELm4EmydqGzBt2F4Q#Value", "Requisition"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-right: 0px;"
},
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
style: "ContainerStatusTitle margin-auto",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [];
}, function () {
return [$if(model.variables.getRequisitionByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_Class: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
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
uuid: "22",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "position-absolute absolute-bottom-right text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width6",
marginLeft: "0"
},
style: "ContainerStatusTitle ",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "",
visible: model.getCachedValue(idService.getId("RUSSIbzxqEKZelBfpc0K1g.Visible"), function () {
return (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut));
}),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
RequisitionId: model.variables.i_RequisitionIdIn
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
uuid: "27",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))))];
}),
column2: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.classAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.labelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.i_RequisitionIdIn)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
ExtendedClass: "custom-columns",
TabletBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "29",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: Fill;"
},
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartingTab: model.getCachedValue(idService.getId("fZ4ZusZGk0aOKGDH_26NtA.StartingTab"), function () {
return ((model.variables.i_IsUploadInvoiceIn) ? (1) : (0));
}, function () {
return model.variables.i_IsUploadInvoiceIn;
}),
OptionalConfigs: model.getCachedValue(idService.getId("fZ4ZusZGk0aOKGDH_26NtA.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
return rec;
}();
})
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
uuid: "31",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "32",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("9PFFfyNH3ka26xWLTn6e3Q#Value", "Details"))];
})
},
_dependencies: []
}), $if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.approved), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "33",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("cBj78NSvaEqA5KjbfHcPNQ#Value", "Invoices"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "34",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-x-18px",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center btn-ADV border-radius-rounded margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "sub-heading",
value: model.getCachedValue(idService.getId("sw_Z6VnQXkuW_QUuo2lXAg.Value"), function () {
return (((model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr === ConectaProveedores_staticEntities_advancePaymentType.withoutInvoice)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SS5VM4SAS0WcqADPnAwnHQ#ValueExpression.-1959430243.1", "Advance Payment Without Invoice")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SS5VM4SAS0WcqADPnAwnHQ#ValueExpression.137569320.1", "Advance Payment")));
}, function () {
return model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr;
}),
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [];
}), createElement(OSWidgets$Form, {
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
uuid: "39",
alias: "10"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UGPVS7z5jUu9FLLEHUWCzw#Value", "Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("y6xGpDcAQUKUi_i_cIIVrA#ValueExpression.2420395.1", "Name"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel flex1",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("kVjoDfUnt0y+_NvUS0vxQQ#Value", "Supplier"))), $if(model.variables.l_CanEditUserAreaVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RequisitionDetailRegionId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr,
_i_RequisitionDetailRegionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_SupplierId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr,
_i_SupplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_IsValid: model.variables.l_DropdownSupplierValidVar,
i_IsDisable: (!(model.variables.l_CanEditUserAreaVar)),
i_IsMandatory: false,
i_IsFilter: false
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (supplierIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.event_ChangeSupplier$Action(supplierIdIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "47",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 500,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr, function (value) {
model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SupplierName"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr)
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
gridProperties: {
classes: "OSInline"
},
style: "vertical-align margin-left-base flex-wrap",
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr))),
extendedProperties: {
style: "margin-bottom: unset;"
},
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.switch_ContractOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Contract"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s ",
text: [$text(getTranslation("+021EvIEcUibNXMHwzJiNw#Value", "There is a contract"))],
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.l_DropdownSupplierValidVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "54"
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
uuid: "55",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if((model.variables.l_CanEditUserAreaVar && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "58",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Advanced"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Cme+aWrJeUac5ROTAJ3NmQ#Value", "Advance ")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)]
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
name: "onlytoshowaftercreation"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "62",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_WasAdvWithoutInvoice_OnlyShow"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ZbjZeG0yXU6ffFtwAGKMiw#Value", "Advance")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)]
}))];
}), $if(false, false, this, function () {
return [];
}, function () {
return [];
})];
}),
column2: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar)]
})), $if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item",
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
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
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
uuid: "68",
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
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_AdvancedPaymentType3",
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_Z30if3QbUyqvJQGAH0Ojg#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("o0hk95Z80ECyXU8eqomVYQ#ValueExpression.2622298.1", "Type"),
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.advancePaymentTypeAttr.labelAttr;
},
list: model.variables.getAdvancedPaymentTypesAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_AdvancedPaymentTypeOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.advancePaymentTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr, function (value) {
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_AdvancedPaymentType3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr),
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
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_AdvancePayment_Amount3",
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_+h2lSZgZESrPB60jXI3Sw#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr, function (value) {
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_AdvancePayment_Amount3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
RightAlign: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
PrefixText: "",
UseNumericInput: true,
InputId: idService.getId("Input_AdvancePayment_Amount3"),
SuffixText: "",
AlwaysShowDecimalDigits: true
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
uuid: "75",
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
style: "os-boxlabel ",
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
mandatory: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr,
targetWidget: "Dropdown_AdvancedPayment_Currency3",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("cfHL2pdUckWHfvoctB38HA#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: " ",
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr,
style: "dropdown ",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr, function (value) {
model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_AdvancedPayment_Currency3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr),
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
uuid: "79"
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
i_Valid: model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr),
i_IsMandatory: true,
i_File: model.getCachedValue(idService.getId("SdqFN0Bg5kubAnSHVHy7yQ.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditUserAreaVar,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9G0K5JINXU6czIKJsUSpOQ#Value.926364987.1", "Document"),
i_StorageId: model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, false, false, false, false, true, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, false, false, false, false, false, true, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "80",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
}
}))];
}, function () {
return [];
}), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "81",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel flex1 margin-bottom-l",
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2ZXptguR40maCnLXb07Z2Q#Value", "Society"))), $if(model.variables.l_CanEditUserAreaVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartingSelection: model.getCachedValue(idService.getId("SocietySearch.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
OptionsList: model.getCachedValue(idService.getId("SocietySearch.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getSupplierSocietiesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.companyAttr.idAttr);
target.labelAttr = ((source.companyAttr.externalIdAttr + "-") + source.companyAttr.descriptionAttr);
target.descriptionAttr = source.companyAttr.rFCAttr;
return target;
});
}, function () {
return model.variables.getSupplierSocietiesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OA9kmgU4sU2S_BkEkf4fpA#Value.-374112632.1", "Society")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.societySearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "SocietySearch",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 100,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SupplierName2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}))];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_BuyDocNr",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7U0gr0c8q0epJlX+H9Utwg#Value", "Buy Doc Nr"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_BuyDocNr"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UnMask: true,
InputId: idService.getId("Input_BuyDocNr"),
MaskPattern: "9999999999"
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
uuid: "91",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
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
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_BuyDocPos",
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("HYKECX7zoESiYkzSI1jp3A#Value", "Buy Doc Pos"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_BuyDocPos"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InputId: idService.getId("Input_BuyDocPos"),
UnMask: true,
MaskPattern: "999999999999"
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
uuid: "95",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
}), $if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr || model.variables.getShowIsDonationDataAct.o_ShowOut), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
gridProperties: {
classes: "OSInline"
},
style: "vertical-align flex-wrap",
visible: true,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_IsDonation"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s ",
text: [$text(getTranslation("p2L588MeKE6xEPf6hxfkBw#Value", "Donation"))],
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getShowIsDonationDataAct.o_ShowOut), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.listOut), asPrimitiveValue(model.variables.getShowIsDonationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar)]
}), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "99",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_Project2",
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("e3dg75rhsUe32yOYq3ZgZw#Value", "Project/Asset/Service"))), createElement(ConectaProveedores_y_Utils_Wb_SearchDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: model.variables.projectAssetMaxRecordVar,
IsEnabled: model.variables.l_CanEditUserAreaVar,
i_Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("U9NYjIgWTEyd7rQqmGy34A#Value.1196787136.1", "Project/Asset/Service"),
ItemsList: model.getCachedValue(idService.getId("xCBsA1_WA0u0v5sr+r3Rjw.ItemsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getProjectAssetServicesAggr.listOut, new (OS$GenericTypeCache.getGenericList(RC_d2eb0d0bdf3678ac335e4faafec1c741))(), function (source, target) {
target.idAttr = source.project_Asset_ServiceAttr.idAttr;
target.nameAttr = source.project_Asset_ServiceAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getProjectAssetServicesAggr.listOut;
}),
_itemsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr),
SelectedName: model.variables.getProjectAssetByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr,
_selectedNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (setMaxRecordsIn, setSearchTextIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_SearchDropdownRefresh_Project$Action(setMaxRecordsIn, setSearchTextIn, controller.callContext(eventHandlerContext));
});
;
},
setVar$Action: function (setIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_SearchDropdownBigSetVar_Project$Action(setIdIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "102",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(true, false, this, function () {
return [];
}, function () {
return [];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr.equals(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_ProjectAssetService",
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2HaCcdZ_ZUuEoXMbsMj0ng#Value", "Project/Asset/Service"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gfM7T9wT80ql4lXjgoO+LA#ValueExpression.1196787136.1", "Project/Asset/Service"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ProjectAssetService"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.projectAssetMaxRecordVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-textarea margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "106"
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
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SR4obNv0gEy_BWLX48tMWA#Value", "Project Description"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
prompt: model.getCachedValue(idService.getId("TextArea_ProjectDescription.Prompt"), function () {
return ((model.variables.l_CanEditUserAreaVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5RSlmERpGU+RZbSQmNZDEw#ValueExpression.13307189.1", "Project Description")) : (""));
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
style: "\"form-control\"",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectDescriptionAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectDescriptionAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_ProjectDescription"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative;"
},
style: "os-boxlabel custom-list-border custom-container margin-bottom-m margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IP7RfOd9akebgn_HXaB7jg#Value", "Services"))), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, true, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: model.variables.l_CanEditUserAreaVar,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getRequisitionServicesByRequisitionIdAggr.listOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative;"
},
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.length), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.descriptionAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.invoiceUsageIdAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.frequencyIdAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext))]
}, createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
style: "height: 85px; left: -38px;"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext), false, true, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditUserAreaVar),
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "119",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "ServiceType_EXP1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("12MASc30sEmHllUrzuS8mg.Style"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? (((model.variables.l_NotValidVar) ? ("not-valid os-boxlabel") : ("os-boxlabel"))) : ("os-boxlabel"));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.l_NotValidVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("R9xEF5xpWEeHxS72pGApTA.Style"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? ((((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr))) ? ("mandatory") : (""))) : (""));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr;
}),
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("8d364ErYFEqERdIUPgRvqQ#Value", "Service Type"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("ServiceType2.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getAccountingAccountsServiceTypesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.accountingAccounts_ServiceTypeAttr.idAttr);
target.labelAttr = source.accountingAccounts_ServiceTypeAttr.cCAttr;
target.descriptionAttr = source.accountingAccounts_ServiceTypeAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getAccountingAccountsServiceTypesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VL4YnTvJQ0C9iY7_Lwe8Qg#Value.1538381499.1", "Service Type "),
StartingSelection: model.getCachedValue(idService.getId("ServiceType2.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
OptionalConfigs: model.getCachedValue(idService.getId("ServiceType2.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = false;
rec.isDisabledAttr = ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? ((!(model.variables.l_CanEditAccountingVar))) : ((!(model.variables.l_CanEditUserAreaVar))));
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pF8yco_D40Ga9AYGSUNfxQ#Value.465267205.1", "Service Type");
return rec;
}();
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.l_CanEditAccountingVar;
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
_optionalConfigsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
name: "ServiceType2",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-base",
visible: model.getCachedValue(idService.getId("xC+8GclFHEuWRbJuyVR1sQ.Visible"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? (model.variables.l_NotValidVar) : (false));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.l_NotValidVar;
}),
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
style: "text-error font-size-xs",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VbIE0WhLlEmbDsZLYKvG1g#ValueExpression.-1029745557.1", "This field is mandatory"),
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "ServiceTypeProduction"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("qnzxKE3RnUe4dZqACEEC_A.Style"), function () {
return ((model.variables.l_NotValidVar) ? ("not-valid os-boxlabel") : ("os-boxlabel"));
}, function () {
return model.variables.l_NotValidVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("64L4NfVSC0yBDRlbEdk+Rg.Style"), function () {
return (((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr))) ? ("mandatory") : (""));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr;
}),
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("csvuHP576U25aBQNFjaOgw#Value", "Service Type"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionsList: model.getCachedValue(idService.getId("ServiceType.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getAccountingAccountsServiceTypesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.accountingAccounts_ServiceTypeAttr.idAttr);
target.labelAttr = source.accountingAccounts_ServiceTypeAttr.cCAttr;
target.descriptionAttr = source.accountingAccounts_ServiceTypeAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getAccountingAccountsServiceTypesAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("BvtpJy+HMEeCRPqM7qOqPg#Value.1538381499.1", "Service Type "),
OptionalConfigs: model.getCachedValue(idService.getId("ServiceType.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.allowMultipleSelectionAttr = false;
rec.isDisabledAttr = (!(model.variables.l_CanEditUserAreaVar));
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eGzeAdGLuEaz9Sw9gDjqaA#Value.465267205.1", "Service Type");
return rec;
}();
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
StartingSelection: model.getCachedValue(idService.getId("ServiceType.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdownSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
name: "ServiceType",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-base",
visible: model.variables.l_NotValidVar,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-error font-size-xs",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("xRmGSbtqYUWrsc0Jg_k8AA#ValueExpression.-1029745557.1", "This field is mandatory"),
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.getCachedValue(idService.getId("Dropdown_Frequency.Mandatory"), function () {
return ((!(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false));
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
targetWidget: "Dropdown_Frequency",
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("lVk0fEY4TkaaPGkm3SPu1Q#Value", "Frequency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DZt9N+xvVkKAXJ0JUA7FCg#ValueExpression.1933944124.1", "Frequency"),
enabled: model.getCachedValue(idService.getId("Dropdown_Frequency.Enabled"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? (model.variables.l_CanEditAccountingVar) : (model.variables.l_CanEditUserAreaVar));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.l_CanEditAccountingVar;
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
labels: function (elem) {
return elem.frequencyAttr.labelAttr;
},
list: model.variables.getFrequenciesAggr.listOut,
mandatory: model.getCachedValue(idService.getId("Dropdown_Frequency.Mandatory"), function () {
return ((!(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false));
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
style: "dropdown",
values: function (elem) {
return elem.frequencyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.frequencyIdAttr, function (value) {
model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.frequencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Frequency"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFrequenciesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
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
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.getCachedValue(idService.getId("Dropdown_InvoiceUsage.Mandatory"), function () {
return ((!(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false));
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
targetWidget: "Dropdown_InvoiceUsage",
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("4RE7LdBATk6L4Y4mu8awKA#Value", "Invoice Usage"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EXFQ5Lu7TU2+RpkTCQw41g#ValueExpression.-177324370.1", "Invoice Usage"),
enabled: model.getCachedValue(idService.getId("Dropdown_InvoiceUsage.Enabled"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? (model.variables.l_CanEditAccountingVar) : (model.variables.l_CanEditUserAreaVar));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.l_CanEditAccountingVar;
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
labels: function (elem) {
return elem.invoiceUsageAttr.descriptionAttr;
},
list: model.variables.getInvoiceUsagesAggr.listOut,
mandatory: model.getCachedValue(idService.getId("Dropdown_InvoiceUsage.Mandatory"), function () {
return ((!(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false));
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
style: "dropdown",
values: function (elem) {
return elem.invoiceUsageAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.invoiceUsageIdAttr, function (value) {
model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.invoiceUsageIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_InvoiceUsage"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
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
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.getCachedValue(idService.getId("Input_AmountByServiceType.Mandatory"), function () {
return ((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)) && ((!(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false)));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr;
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
targetWidget: "Input_AmountByServiceType",
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("as5yG7KYRUW0lHOn8u7pcg#Value", "Amount w/o IVA"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.getCachedValue(idService.getId("Input_AmountByServiceType.Enabled"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) ? (model.variables.l_CanEditAccountingVar) : (model.variables.l_CanEditUserAreaVar));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.l_CanEditAccountingVar;
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: model.getCachedValue(idService.getId("Input_AmountByServiceType.Mandatory"), function () {
return ((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)) && ((!(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false)));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr;
}, function () {
return model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr;
}),
maxLength: 0,
prompt: " ",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.amountAttr, function (value) {
model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_AmountByServiceType"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
SuffixText: "",
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
GroupSeparator: ",",
InputId: idService.getId("Input_AmountByServiceType"),
DecimalSeparator: ".",
RightAlign: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2)
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
uuid: "141",
alias: "27"
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
WidgetId: idService.getId("Input_AmountByServiceType"),
DebounceDelay: 350
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.recalculateTotalAmount$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "142",
alias: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.invoiceUsageIdAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.frequencyIdAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.accountingServiceTypeIdAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-textarea",
visible: true,
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_Description",
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ig5KMuplgEyY9qM6QsXxVQ#Value", "Service Description"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
prompt: model.getCachedValue(idService.getId("TextArea_Description.Prompt"), function () {
return ((model.variables.l_CanEditUserAreaVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gCRzvLi3JUuzfLZPb+rOcQ#ValueExpression.1626734289.1", "Service Description")) : (""));
}, function () {
return model.variables.l_CanEditUserAreaVar;
}),
style: "\"form-control\"",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.descriptionAttr, function (value) {
model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionServiceAttr.descriptionAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_Description"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr)
})), $if((model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.getCurrentRowNumber(callContext.iterationContext) === (model.variables.getRequisitionServicesByRequisitionIdAggr.listOut.length - 1)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-flex-end",
visible: true,
_idProps: {
service: idService,
uuid: "146"
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
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.medium,
IsVertical: false,
ExtendedClass: "background-color-transpblue",
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "148",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-neutral-1",
visible: true,
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Space: ConectaProveedores_staticEntities_space.medium,
IsVertical: false,
ExtendedClass: "background-color-transpblue",
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "150",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})];
}),
rightActions: Widget.PlaceholderContent.Empty
}
}))];
}, callContext, idService, "5")
},
_dependencies: [asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-list-item",
visible: true,
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "152",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: Widget.PlaceholderContent.Empty,
column2: Widget.PlaceholderContent.Empty,
column3: Widget.PlaceholderContent.Empty,
column4: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_CategoryValue3",
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yif2lMwdikG2sX+z7ByYwA#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: 0;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: " ",
style: "form-control bold",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_CategoryValue3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalSeparator: ".",
PrefixText: "",
InputId: idService.getId("Input_CategoryValue3"),
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: true,
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
uuid: "156",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr)]
}))), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "157",
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)),
targetWidget: "Dropdown_Distribution",
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("YEGnMbmbzk27us0IDK8JcQ#Value", "Distribution"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("w__zYcmsXk+NpxAM3Fqt8w#ValueExpression.-1416387932.1", "Distribution"),
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.distributionAttr.labelAttr;
},
list: model.variables.getDistributionsAggr.listOut,
mandatory: (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)),
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_DistributionOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.distributionAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Distribution"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDistributionsAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr === ConectaProveedores_staticEntities_distribution.fixed) && model.variables.getCostCentersAggr.isDataFetchedAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel flex1",
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
title: ("ID: " + OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr))
},
text: [$text(getTranslation("tIcONUYFUECPSKPhumS7aQ#Value", "Cost center"))],
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(model.variables.l_CanEditUserAreaVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qsONT0nunkqSUhjnxANRLQ#Value.-1520949240.1", "Cost Center"),
OptionsList: model.getCachedValue(idService.getId("CostCenterSearch.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getCostCentersAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.costCenterSAPAttr.idAttr);
target.labelAttr = source.costCenterSAPAttr.ce_costeAttr;
target.groupNameAttr = ("CeBe " + source.costCenterSAPAttr.ceBeAttr);
target.descriptionAttr = ((source.costCenterSAPAttr.denominacionAttr + " - ") + source.costCenterSAPAttr.div_Attr);
return target;
});
}, function () {
return model.variables.getCostCentersAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCostCentersAggr.dataFetchStatusAttr),
StartingSelection: model.getCachedValue(idService.getId("CostCenterSearch.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_CostCenterSearchOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "CostCenterSearch",
alias: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr, function (value) {
model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr = value;
}),
_idProps: {
service: idService,
name: "Input_SupplierName3"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr)
}))];
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getDistributionsAggr.listOut), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDistributionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)]
}), $if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "168"
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
uuid: "169",
alias: "35"
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
style: "vertical-align margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Sustainability"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("UEZdZF0zME6XDOjDt_VVkg#Value", "Sustainability"))],
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.variables.l_CanEditUserAreaVar,
targetWidget: "Dropdown_Sustainability",
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3rksw8XJtEeeY30A+I_GcQ#Value", "Sustainability"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("czrdBAJmC02Qj9YK_c+rtg#ValueExpression.-464453177.1", "Sustainability"),
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.sustainabilityAttr.descriptionAttr;
},
list: model.variables.getSustainabilitiesAggr.listOut,
mandatory: model.variables.l_CanEditUserAreaVar,
style: "dropdown",
values: function (elem) {
return elem.sustainabilityAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Sustainability"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSustainabilitiesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getSustainabilitiesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getSustainabilitiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "176"
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
uuid: "177",
alias: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: model.variables.l_CanEditUserAreaVar,
targetWidget: "Dropdown_BusinessCategoryValue",
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("swna6zbUDUKFZ5R+WkYFGg#Value", "Business Value"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XGVkQI7eok2lqDlb+P0_Zg#ValueExpression.115155230.1", "Category"),
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.businessValueCategoryAttr.descriptionAttr;
},
list: model.variables.getBusinessValueCategoriesAggr.listOut,
mandatory: model.variables.l_CanEditUserAreaVar,
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
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategoryValue"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
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
style: "os-boxlabel margin-bottom-l",
visible: true,
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.l_CanEditUserAreaVar && (!(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut.isEmpty))),
targetWidget: "Dropdown_BusinessCategorySubValue",
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("GcsWtJObLUqLsZkppJ8QJw#Value", "Sub-Value"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wkTgr3pvPkupAtgig9berg#ValueExpression.-1326718178.1", "Subcategory"),
enabled: (model.variables.l_CanEditUserAreaVar && (!(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut.isEmpty))),
labels: function (elem) {
return elem.businessValueSubcategoryAttr.descriptionAttr;
},
list: model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut,
mandatory: (model.variables.l_CanEditUserAreaVar && (!(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut.isEmpty))),
style: "dropdown",
values: function (elem) {
return elem.businessValueSubcategoryAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_BusinessCategorySubValue"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr),
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar)]
}))];
}, function () {
return [];
}), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "184",
alias: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [$if((model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr === "MX"), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_PaymentMethod",
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NcYmtj8YaUG+NqU6HOnANw#Value", "Payment Method"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("xXTd4MNLNEOe_28z0I3pCw#ValueExpression.1269271675.1", "Payment Method"),
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.paymentOptionsAttr.descriptionAttr;
},
list: model.variables.getPaymentOptionsAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.paymentOptionsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentMethod"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
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
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_PaymentTerm",
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("apoUwPVPwkmVUQYpamlnDw#Value", "Payment Term"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9t6zAWlAUEmDWiu8JmZwzw#ValueExpression.-391766394.1", "Payment Term"),
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.paymentWaysAttr.descriptionAttr;
},
list: model.variables.getPaymentWaysAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.paymentWaysAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTerm"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentWaysAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
}), $if(false, false, this, function () {
return [];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-l",
visible: false,
_idProps: {
service: idService,
uuid: "191"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xB3J8HL1N0qMC+iC_U2PvQ#Value", "Service Format"))), $if(model.variables.l_CanEditUserAreaVar, false, this, function () {
return [createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartingSelection: model.getCachedValue(idService.getId("Dropdown_ServiceFormat.StartingSelection"), function () {
return function () {
var list = new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
list.pushAll([function () {
var rec = new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure();
rec.valueAttr = OS$BuiltinFunctions.longIntegerToText(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr);
rec.labelAttr = "";
return rec;
}()]);
return list;
}();
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr;
}),
_startingSelectionInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FEPyj0zQHkisXSk9vwCfIQ#Value.32.1", " "),
OptionalConfigs: model.getCachedValue(idService.getId("Dropdown_ServiceFormat.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.isDisabledAttr = (!((model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId())))));
return rec;
}();
}, function () {
return model.variables.i_RequisitionIdIn;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}),
_optionalConfigsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
OptionsList: model.getCachedValue(idService.getId("Dropdown_ServiceFormat.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getServiceFormatsAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = OS$BuiltinFunctions.longIntegerToText(source.serviceFormatAttr.idAttr);
target.labelAttr = source.serviceFormatAttr.descriptionAttr;
return target;
});
}, function () {
return model.variables.getServiceFormatsAggr.listOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getServiceFormatsAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdownSearchOnChangedFormats$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "Dropdown_ServiceFormat",
alias: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
enabled: false,
labels: function (elem) {
return elem.serviceFormatAttr.descriptionAttr;
},
list: model.variables.getServiceFormatsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.serviceFormatAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_ServiceFormat2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getServiceFormatsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
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
uuid: "195",
alias: "39"
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
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_Currency",
_idProps: {
service: idService,
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mJtbLd0lTEG0KafZ4oVLSA#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NQcOiZsawkGNOq8JG0moFg#ValueExpression.640046129.1", "Currency"),
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_CurrencyOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Currency"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel",
visible: model.getCachedValue(idService.getId("qfRBtOYMsEOeOtCBPTL7nQ.Visible"), function () {
return (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (ConectaProveedores_staticEntities_currency.mXN)) && ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
}),
_idProps: {
service: idService,
uuid: "199"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_NegotiatedExchangeRate",
_idProps: {
service: idService,
uuid: "200"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("z6s_07zkvEi55wSi1_hW+g#Value", "Exchange Rate"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: "N/A",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_NegotiatedExchangeRate"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
InputId: idService.getId("Input_NegotiatedExchangeRate"),
SuffixText: "",
RightAlign: true,
DecimalSeparator: ".",
UseNumericInput: true,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true
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
uuid: "202",
alias: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getServiceFormatsAggr.listOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getPaymentWaysAggr.listOut), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getPaymentOptionsAggr.listOut), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "203"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr || model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(BigUpload_BigUpload_wb_BigUploadSingleFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Message: "",
IsEnable: model.getCachedValue(idService.getId("l0MNTbD5zku5ieKG8SyThg.IsEnable"), function () {
return (((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.modify)) || model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? (true) : (false));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr;
}, function () {
return model.variables.i_RequisitionIdIn;
}),
_isEnableInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("PxN1SPh4VUOh9kIB1QUnlQ#Value.-1666281426.1", "Finance Area Autorization"),
ShowStatus: true,
MaxSize: 100,
isValid: model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr.isValidAttr,
_isValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr),
Filename: model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr,
_filenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr),
IsMandatory: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
notifyFileId$Action: function (fileIdIn, filenameIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadNotifyFileId$Action(fileIdIn, filenameIn, controller.callContext(eventHandlerContext));

;
},
eventstartProcess$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadEventstartProcess$Action(controller.callContext(eventHandlerContext));

;
},
eventEndProcess$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadEventEndProcess$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "205",
alias: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}), $if((((model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) && !(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "206"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
uuid: "207",
alias: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8KE8AAOg+UixTVFyl0Cs4g#Value.1873836557.1", "Proof Of Foreign Residence"),
i_FilesMaxSize: 20971520,
i_IsMandatory: model.getCachedValue(idService.getId("wQ6EYl_lmkmtoa5Ryo5T7g.i_IsMandatory"), function () {
return (((model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) && !(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, function () {
return model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr;
}, function () {
return model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr;
}),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr),
i_IsEnabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
i_File: model.getCachedValue(idService.getId("wQ6EYl_lmkmtoa5Ryo5T7g.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr),
i_Valid: model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, true, false, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, true, false, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "208",
alias: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "209"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
style: "mandatory",
targetWidget: "Dropdown_RetentionPercentage2",
_idProps: {
service: idService,
uuid: "210"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("W+mRzomr+UK1BxxMdmKp9g#Value", "Retention Percentage"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
enabled: model.variables.l_CanEditUserAreaVar,
labels: function (elem) {
return elem.textAttr;
},
list: model.variables.l_RetentionPercentageListVar,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.valueAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_RetentionPercentage2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RetentionPercentageListVar), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.validAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr)]
}))];
}, function () {
return [];
})), $if(false, false, this, function () {
return [];
}, function () {
return [];
}), $if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("de9uMbwazkee3eX9iPG0lg.Style"), function () {
return ((model.variables.l_NotValidContractValueVar) ? ("os-boxlabel custom-container margin-top-m not-valid-payments") : ("os-boxlabel custom-container  margin-top-m"));
}, function () {
return model.variables.l_NotValidContractValueVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "212"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "213"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aerc3L3+QUSXFz_cF0YX8Q#Value", "Contract"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "215"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; margin-top: 10px; border-color: var(--color-neutral-6);"
},
style: "os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "216"
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
uuid: "217"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bbDN4_CJ90WBk1HlWNks0A#Value", "Contract Pending"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_ContractPending"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: model.getCachedValue(idService.getId("te_xy+ILjUyucL9ig7feww.Style"), function () {
return ("margin-top-s " + ((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved))) ? (" ") : ("max-height45px")));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}),
visible: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr,
_idProps: {
service: idService,
uuid: "219"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "220",
alias: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "221"
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
uuid: "222",
alias: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditUserAreaVar,
i_StorageId: model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_FilesMaxSize: 20971520,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9_d5xnlA2kapl4eGJ_BAlw#Value.-1631012142.1", "Justification"),
i_File: model.getCachedValue(idService.getId("LXsi00SBKUKrQFV8OdfNxQ.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_Valid: model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, false, false, true, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, false, false, false, true, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "223",
alias: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "224"
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
TimeFormat: ConectaProveedores_staticEntities_datePickerTimeFormat.disabled,
ShowTodayButton: true,
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerPaymentDateRequisitions.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
rec.initialDateAttr = model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr;
rec.minDateAttr = ((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved))) ? (OS$BuiltinFunctions.currDateTime()) : (OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.currDateTime(), 1)));
rec.maxDateAttr = ((model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) ? (OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.currDateTime(), model.variables.getConfigurationDataAct.uploadContractDateLimitOut)) : (((model.variables.l_CanEditUserAreaVar) ? (((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.addDays(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr, model.variables.getConfigurationDataAct.uploadContractDateLimitOut)) : (OS$BuiltinFunctions.addDays(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr, model.variables.getConfigurationDataAct.uploadContractDateLimitOut)))) : (OS$BuiltinFunctions.addDays(OS$BuiltinFunctions.currDateTime(), model.variables.getConfigurationDataAct.uploadContractDateLimitOut)))));
return rec;
}();
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}, function () {
return model.variables.i_RequisitionIdIn;
}, function () {
return model.variables.getConfigurationDataAct.uploadContractDateLimitOut;
}, function () {
return model.variables.l_CanEditUserAreaVar;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr;
}),
_optionalConfigsInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getConfigurationDataAct.dataFetchStatusAttr),
DateFormat: "DD/MM/YYYY",
ExtendedClass: "custom-datepicker"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnSelected$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "DatePickerPaymentDateRequisitions",
alias: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "226"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr),
targetWidget: "Input_DateOfCommitment",
_idProps: {
service: idService,
uuid: "227"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("6oqSAlahOUCVcBYYdiWxxQ#Value", "Date of Commitment"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "228",
alias: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "padding: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "229"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickOpenDatePickerDateOfCommitment$Action(controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
style: "margin-top: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "230"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.getCachedValue(idService.getId("Input_DateOfCommitment.Enabled"), function () {
return (model.variables.l_CanEditUserAreaVar || ((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()) && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr))) && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr))) && OS$BuiltinFunctions.currDate().lte(OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addDays(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr, model.variables.getConfigurationDataAct.uploadContractDateLimitOut)))));
}, function () {
return model.variables.l_CanEditUserAreaVar;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr;
}, function () {
return model.variables.getConfigurationDataAct.uploadContractDateLimitOut;
}),
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onClickOpenDatePickerDateOfCommitment$Action(controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr),
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4f4lagTUUUa4cfRSJNiGvQ#ValueExpression.1002767249.1", "Select a date"),
style: model.getCachedValue(idService.getId("Input_DateOfCommitment.Style"), function () {
return ("form-control " + (((model.variables.l_CanEditUserAreaVar || ((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()) && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr))) && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr))) && OS$BuiltinFunctions.currDate().lte(OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addDays(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr, model.variables.getConfigurationDataAct.uploadContractDateLimitOut)))))) ? (" cursorpointer") : (" ")));
}, function () {
return model.variables.l_CanEditUserAreaVar;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr;
}, function () {
return model.variables.getConfigurationDataAct.uploadContractDateLimitOut;
}),
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DateOfCommitment"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getConfigurationDataAct.dataFetchStatusAttr),
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getConfigurationDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr)]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.variables.l_ShowSavePendingInfoBtnVar,
_idProps: {
service: idService,
uuid: "232"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveContractPendingInfo$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn",
visible: model.variables.l_ShowSavePendingInfoBtnVar,
_idProps: {
service: idService,
uuid: "233"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nvWTC5iA8kKKKBmQEcjv2w#Value", "Save"))))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Valid: model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr),
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_FilesMaxSize: 20971520,
i_IsEnabled: model.variables.l_CanEditUserAreaVar,
i_StorageId: model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4DNokNiA9Eauz6VULsqb1Q#Value.-1666281426.1", "Finance Area Autorization"),
i_File: model.getCachedValue(idService.getId("+s8Vhv0U90irTa3x0qZOEg.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, true, false, false, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, true, false, false, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "234",
alias: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.approved)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "235"
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
i_IsEnabled: model.getCachedValue(idService.getId("aHVqxDwNXEawf_OgBxKJwg.i_IsEnabled"), function () {
return (((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr)) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId())) && OS$BuiltinFunctions.currDate().lte(model.variables.l_OriginalDateOfCommitmentVar));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}, function () {
return model.variables.l_OriginalDateOfCommitmentVar;
}),
_i_IsEnabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_StorageId: model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_File: model.getCachedValue(idService.getId("aHVqxDwNXEawf_OgBxKJwg.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_Valid: model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+z3L6oaoxk2Q+OYRxJwHKw#Value.-502303438.1", "Contract")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "236",
alias: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_OriginalDateOfCommitmentVar), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr), asPrimitiveValue(model.variables.l_ShowSavePendingInfoBtnVar), asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr)]
})))];
}, function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "237",
alias: "51"
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
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "238"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditUserAreaVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_ContractPending2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("EcdkFLeebEaSZSYWKIu4GQ#Value", "Contract Pending"))],
_idProps: {
service: idService,
uuid: "240"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "241"
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
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VXCpWzDoTEaPvQF19jrXiQ#Value.-502303438.1", "Contract"),
i_FilesMaxSize: 20971520,
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr && (!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr))),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditUserAreaVar,
i_Valid: model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_File: model.getCachedValue(idService.getId("QGZxBKrizki0kxTdLRr5ZQ.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, true, false, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "242",
alias: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr)]
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "243"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, false, true, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "244",
alias: "53"
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
uuid: "245"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "246"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VJoFTqbTiEuln2qz+O+JOA#Value", "Attach Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "247"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: model.getCachedValue(idService.getId("x3wvgRO2SE2EObowFEzYcQ.Style"), function () {
return (((model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar)) ? ("text-neutral-9") : ("text-neutral-7"));
}, function () {
return model.variables.l_CanEditUserAreaVar;
}, function () {
return model.variables.l_CanEditAccountingVar;
}),
text: [$text(getTranslation("x3wvgRO2SE2EObowFEzYcQ#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "248"
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
uuid: "249"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "250"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
uuid: "251"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ConectaProveedores_staticEntities_size.small,
Color: ConectaProveedores_staticEntities_color.neutral3
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
uuid: "252",
alias: "54"
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
uuid: "253"
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
i_Text: model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
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
uuid: "254",
alias: "55"
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
uuid: "255"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.getCurrentRowNumber(callContext.iterationContext), false, false, true, false, false, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "256"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "257"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr)]
}))];
}, callContext, idService, "15")
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)]
}))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("CSGCbVcFWUemn+jtIJ70Xg.style"), function () {
return ((model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.isEmpty) ? ("top: 10px;") : ("top: 12px;"));
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut.isEmpty;
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
uuid: "258"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "259"
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
name: "Deposit2"
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
uuid: "261"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NLHDlot49EqDF9lqmYsOCQ#Value", "Deposit"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_DepositOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Deposit2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(true, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr && (model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.length < 3)) && (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar)),
_idProps: {
service: idService,
uuid: "263"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "264"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-xs",
visible: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr,
_idProps: {
service: idService,
uuid: "265"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "266"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
controller.removeFromList$Action(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext), true, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar)),
_idProps: {
service: idService,
uuid: "268"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "269"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "270"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
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
alias: "56"
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
targetWidget: "Dropdown_DepositType2",
_idProps: {
service: idService,
uuid: "273"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3AqZ+SMmpESCpfcdK63hDA#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("PJ8UoJmx102CP5FQ9cxTqQ#ValueExpression.2622298.1", "Type"),
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.depositTypeAttr.labelAttr;
},
list: model.variables.getDepositTypesAggr.listOut,
mandatory: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_DepositTypeOnChange$Action(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.depositTypeIdAttr, model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.depositTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.depositTypeIdAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.depositTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_DepositType2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getDepositTypesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
targetWidget: "Input_Deposit_Amount2",
_idProps: {
service: idService,
uuid: "276"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IFKqwYq_WkerJT85S_c7zA#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Deposit_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalSeparator: ".",
SuffixText: "",
GroupSeparator: ",",
UseNumericInput: true,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_Deposit_Amount2"),
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
uuid: "278",
alias: "57"
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
uuid: "279"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_Deposit_Currency2",
_idProps: {
service: idService,
uuid: "280"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VBj50DIVRkWp_zd8czEVJg#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9Hml2W0gM0uFrb6f1tJG6A#ValueExpression.640046129.1", "Currency"),
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: true,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Deposit_Currency2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
uuid: "282"
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
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cCDQNpbog0qyDXDKtGWycQ#Value.926364987.1", "Document"),
i_IsMandatory: true,
i_FilesMaxSize: 20971520,
i_File: model.getCachedValue(idService.getId("E5Eoasek40CxYnKmZb00Dw.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_Valid: model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_IsEnabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, true, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, true, false, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "283",
alias: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.depositTypeIdAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.depositTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut.getCurrentRowNumber(callContext.iterationContext))]
})];
}, callContext, idService, "18")
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6);"
},
style: "os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
name: "Insurance2"
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
uuid: "285"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("DElNbrk_Z0W0iyNAclBNXA#Value", "Insurance"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_InsuranceOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Insurance2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, false, true, false, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr && (model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.length < 4)) && (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar)),
_idProps: {
service: idService,
uuid: "287"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "288"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-xs",
visible: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr,
_idProps: {
service: idService,
uuid: "289"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "290"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
controller.removeFromList$Action(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext), false, false, false, true, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && (model.variables.l_CanEditAccountingVar || model.variables.l_CanEditUserAreaVar)),
_idProps: {
service: idService,
uuid: "292"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height : 25px"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_quitar_lleno.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "293"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "294"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
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
uuid: "295",
alias: "59"
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
uuid: "296"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_Insurance2",
_idProps: {
service: idService,
uuid: "297"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("v1o0a_kvPkm2LBYBcDTfNw#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_9Kti19f1EKaGSqeoOyf_g#ValueExpression.2622298.1", "Type"),
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.insuranceTypeAttr.labelAttr;
},
list: model.variables.getInsuranceTypesAggr.listOut,
mandatory: false,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_InsuranceTypeOnChange$Action(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.insuranceTypeIdAttr, model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.insuranceTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.insuranceTypeIdAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.insuranceTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Insurance2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
uuid: "299"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Insurance_Amount2",
_idProps: {
service: idService,
uuid: "300"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("c9TgQZlVpE6Pg_bBBg9RoA#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Insurance_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_Insurance_Amount2"),
SuffixText: "",
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
RightAlign: true,
PrefixText: "",
GroupSeparator: ",",
DecimalSeparator: "."
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
uuid: "302",
alias: "60"
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
uuid: "303"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_Insurance_Currency2",
_idProps: {
service: idService,
uuid: "304"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("e07Dcjp_CkGn+mvBAkt6Rw#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RfMhHiPTfEmZtIqxkZQx0Q#ValueExpression.640046129.1", "Currency"),
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: true,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Insurance_Currency2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
uuid: "306"
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
i_StorageId: model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_IsMandatory: true,
i_Valid: model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_IsEnabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jy4XmbuVREOddNCdscwpcw#Value.926364987.1", "Document"),
i_File: model.getCachedValue(idService.getId("arHRYPsSeEy1GKcI9xxQ+g.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, true, false, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
_idProps: {
service: idService,
uuid: "307",
alias: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.insuranceTypeIdAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionContractFileAttr.insuranceTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrentRowNumber(callContext.iterationContext))]
})];
}, callContext, idService, "21")
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.l_CanEditAccountingVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6);"
},
style: "os-boxlabel custom-container",
visible: false,
_idProps: {
service: idService,
name: "AdvancePayment"
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
uuid: "309"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Ize5YIfrYkeG4BBV8kLqWA#Value", "Advance Payment "))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_AdvancedPayment2OnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_AdvancedPayment2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-xs",
visible: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr,
_idProps: {
service: idService,
uuid: "311"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$ListItem, {
style: "list-item custom-list-item",
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
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "313"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns4_mvc_view, {
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
uuid: "314",
alias: "62"
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
uuid: "315"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_AdvancedPaymentType2",
_idProps: {
service: idService,
uuid: "316"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Fx7aTTdJXE2u_GmJJtSodA#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iczUS4tmd0+jUjK1UTTi3w#ValueExpression.2622298.1", "Type"),
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.advancePaymentTypeAttr.labelAttr;
},
list: model.variables.getAdvancedPaymentTypesAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.advancePaymentTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_AdvancedPaymentType2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
uuid: "318"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_AdvancePayment_Amount2",
_idProps: {
service: idService,
uuid: "319"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8ofhONIwckaDDLPBmVIpQw#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_AdvancePayment_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UseNumericInput: true,
RightAlign: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
InputId: idService.getId("Input_AdvancePayment_Amount2"),
PrefixText: "",
GroupSeparator: ",",
SuffixText: "",
AlwaysShowDecimalDigits: true
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
uuid: "321",
alias: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "322"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_AdvancedPayment_Currency2",
_idProps: {
service: idService,
uuid: "323"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Nw8baXuhQEu0g9ZAwmFD6Q#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XOg+VHTUR0OFi1LiuvVU2w#ValueExpression.640046129.1", "Currency"),
enabled: false,
extendedProperties: {
style: "margin-bottom: unset;"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: true,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr, function (value) {
model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_AdvancedPayment_Currency2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
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
uuid: "325"
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
i_IsMandatory: true,
i_StorageId: model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_IsEnabled: (model.variables.l_CanEditUserAreaVar || model.variables.l_CanEditAccountingVar),
i_File: model.getCachedValue(idService.getId("3_wd4cq9DUixr7FZpp+LUQ.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("36+lxWIoCUCSSYJ2QAHQPw#Value.926364987.1", "Document"),
i_Valid: model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr),
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, true, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, true, false, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "326",
alias: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut.getCurrent(callContext.iterationContext).requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr)]
}))];
}),
rightActions: Widget.PlaceholderContent.Empty
}
}))))))];
}, function () {
return [];
}), $if(((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr) && model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("Payments.Style"), function () {
return ((model.variables.l_NotValidPaymentsValueVar) ? ("os-boxlabel custom-container margin-top-m not-valid-payments") : ("os-boxlabel custom-container  margin-top-m"));
}, function () {
return model.variables.l_NotValidPaymentsValueVar;
}),
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
uuid: "328"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4a+mxJ4BuEGjg4qkaZTjcA#Value", "Payments"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "329"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getAccountingDataDataAct.isDataFetchedAttr && (!(model.variables.getAccountingDataDataAct.hasFetchErrorAttr))), false, this, function () {
return [$if(model.variables.l_CanSeeAdvanceWithOrWithoutInvoiceVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "330"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); margin-top:unset;"
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "331"
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
uuid: "332"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Estimaciones / Iguala / Pagos Acordados"), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_IsActiveOnChange$Action(controller.callContext(eventHandlerContext));

;
},
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
}), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addRecord$Action(false, false, false, true, false, controller.callContext(eventHandlerContext));

;
},
style: "custom-plus-button",
visible: (((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.length < 3) && model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr) && model.variables.l_CanEditAccountingVar),
_idProps: {
service: idService,
uuid: "334"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.blueplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "335"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-xs",
visible: model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "336"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
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
uuid: "337"
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
name: "ListItem6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext), false, false, false, false, true, controller.callContext(eventHandlerContext));

;
},
style: "custom-minus-button align-column-vertically",
visible: (((model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext)) !== (0)) && model.variables.l_CanEditAccountingVar),
_idProps: {
service: idService,
uuid: "339"
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
uuid: "340"
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
uuid: "341",
alias: "65"
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
uuid: "342"
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
uuid: "343"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("i8tut9dpt0aAiInoCWIx+A#Value", "Type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iakt_cD8lk+_VNPZVDR+1w#ValueExpression.2622298.1", "Type"),
enabled: model.variables.l_CanEditAccountingVar,
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
uuid: "345"
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
uuid: "346"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("eP8kGgc2O0+pQ8JZ04SM5w#Value", "Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
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
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "348"
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
uuid: "349"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("85dzATcUgE+aJlt5oBz_TQ#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
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
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalSeparator: ".",
InputId: idService.getId("Input_Estim_Equal_Agreed_Amount"),
PrefixText: "",
AlwaysShowDecimalDigits: true,
SuffixText: "",
RightAlign: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true
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
uuid: "351",
alias: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column4: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "352"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_Estim_Equal_Agreed_Currency",
_idProps: {
service: idService,
uuid: "353"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1jTjReduak2nvH3nIqYLtw#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+aa6wxJRSkKGDvvEhlisuQ#ValueExpression.640046129.1", "Currency"),
enabled: model.variables.l_CanEditAccountingVar,
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).currencyIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Estim_Equal_Agreed_Currency"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).currencyIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr)]
})];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).currencyIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).numberOfPaymentsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrent(callContext.iterationContext).accountingDataTypeIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr.getCurrentRowNumber(callContext.iterationContext))]
})];
}, callContext, idService, "26")
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_CanEditAccountingVar)]
}))), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "margin-bottom-base"
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
uuid: "355",
alias: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "356"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getAccountingDataDataAct.o_RemainingOut,
style: "list list-group overflow-visible",
tag: "div",
_idProps: {
service: idService,
uuid: "357"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$ListItem, {
extendedProperties: {
style: "padding-top: unset;"
},
style: "list-item custom-list-item overflow-visible",
triggerActionOnFullSwipeLeft: true,
triggerActionOnFullSwipeRight: true,
_idProps: {
service: idService,
name: "ListItem4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
leftActions: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); margin-top: unset;"
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "359"
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
uuid: "360"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).accountingDataTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "361"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.switch_ConceptOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.isActiveAttr, function (value) {
model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.isActiveAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_Concept"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s max-height45px",
visible: model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.isActiveAttr,
_idProps: {
service: idService,
uuid: "363"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
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
uuid: "364",
alias: "68"
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
uuid: "365"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Concept_Amount",
_idProps: {
service: idService,
uuid: "366"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3ih__lGHOkabksF2A0MiQw#Value", "Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: true,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.amountAttr, function (value) {
model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.amountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Concept_Amount"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
SuffixText: "",
UseNumericInput: true,
PrefixText: "",
RightAlign: true,
InputId: idService.getId("Input_Concept_Amount")
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
uuid: "368",
alias: "69"
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
uuid: "369"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_Concept_Currency",
_idProps: {
service: idService,
uuid: "370"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QK26Z3l+ikGi1EO_BdX6IQ#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.ownerService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iXjUfL+cfk+cVfp_kTNZVQ#ValueExpression.640046129.1", "Currency"),
enabled: model.variables.l_CanEditAccountingVar,
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.currencyIdAttr, function (value) {
model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_Concept_Currency"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.amountAttr)]
})))];
}),
rightActions: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.amountAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).requisitionAccConceptsAttr.isActiveAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut.getCurrent(callContext.iterationContext).accountingDataTypeAttr.labelAttr)]
})];
}, callContext, idService, "28")
},
_dependencies: [asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "position: relative; border-color: var(--color-neutral-6); margin-top: unset;"
},
style: "os-boxlabel custom-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "372"
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
uuid: "373"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("l5MYru1AwUuZJpLDYSxkdA#Value", "Special Authorization"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
style: "switch custom-toggle",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_SpecialAuthorization"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
marginLeft: "0px"
},
style: "margin-top-s max-height45px",
visible: model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr,
_idProps: {
service: idService,
uuid: "375"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kTUtMHybhkSobmfP_hUdSw#ValueExpression.1276767183.1", "Select a special authorization"),
enabled: model.variables.l_CanEditAccountingVar,
extendedProperties: {
style: "margin-bottom: var(--space-xs);"
},
labels: function (elem) {
return elem.specialPostDeliveryAuthorizationAttr.labelAttr;
},
list: model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.specialPostDeliveryAuthorizationAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_SpecialAuthorization_Currency"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "377"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_PaymentMethodId",
_idProps: {
service: idService,
uuid: "378"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ln0nSbNdBkqLG3aBysMS6w#Value", "Payment Method"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NG8NmxVHZUKJ_tj0hY26Mg#ValueExpression.722673599.1", "Select payment method"),
enabled: model.variables.l_CanEditAccountingVar,
labels: function (elem) {
return elem.descriptionAttr;
},
list: model.variables.getPaymentMethodsBySupplierIdDataAct.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentMethodId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
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
mandatory: true,
targetWidget: "Dropdown_PaymentTermsId",
_idProps: {
service: idService,
uuid: "381"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6S0zz2Uw3EuY6Y1KGVfi5A#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("eVCfSmrBSUSqnfzN9ZQIZg#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditAccountingVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: true,
style: "dropdown",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.listOut), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut)]
}), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "383",
alias: "70"
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
uuid: "384",
alias: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel",
visible: model.getCachedValue(idService.getId("4Eeeaxfe00ir7FWBSwPoTg.Visible"), function () {
return (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (ConectaProveedores_staticEntities_currency.mXN)) && ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
}),
_idProps: {
service: idService,
uuid: "385"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_NegotiatedExchangeRate_Accounting",
_idProps: {
service: idService,
uuid: "386"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("eG2P6ouCTUKSIxwSLp5C9g#Value", "Exchange Rate"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: "N/A",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr = value;
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
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
RightAlign: true,
UseNumericInput: true,
SuffixText: "",
InputId: idService.getId("Input_NegotiatedExchangeRate_Accounting"),
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
uuid: "388",
alias: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-base",
visible: !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr)),
_idProps: {
service: idService,
uuid: "389"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr, model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("J1_JECK9AUCFe++1BaBmjw#Value.447611511.1", "Evidence"),
i_File: model.getCachedValue(idService.getId("YdZnDK3g3ka_GSVocY+e2w.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditAccountingVar,
i_FilesMaxSize: 20971520,
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_Valid: model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, false, true, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, true, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "390",
alias: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr)]
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel custom-textarea",
visible: !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr)),
_idProps: {
service: idService,
uuid: "391"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr, model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))),
targetWidget: "TextArea_ExchangeRateComment",
_idProps: {
service: idService,
uuid: "392"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, $text(getTranslation("gFrH0W7+CkC_CakqJL2fRg#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))),
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zJAC28DHIkS233H5ZNO6Dg#ValueExpression.-1679915457.1", "Comment"),
style: "\"form-control\"",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_ExchangeRateComment"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr)]
}), createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "394",
alias: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "395"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
gridProperties: {
classes: "ThemeGrid_Width4"
},
style: "vertical-align margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "396"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_REPSE"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("WhdQK6e7okqmQJ6rAc3PCw#Value", "REPSE"))],
_idProps: {
service: idService,
uuid: "398"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "ThemeGrid_Width8 ThemeGrid_MarginGutter"
},
visible: model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr,
_idProps: {
service: idService,
uuid: "399"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: model.variables.l_CanEditAccountingVar,
i_Valid: model.variables.getAccountingDataDataAct.rEPSEOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_FilesMaxSize: 20971520,
i_File: model.getCachedValue(idService.getId("m1iD3wJR6Em87NotIDZJBg.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("toKhv2EMg0yphUYj5emagQ#Value.77863823.1", "REPSE")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, false, false, false, true, false, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, false, false, false, false, true, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "400",
alias: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}),
column2: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "401"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasNoticeOfPaymentSuspensionAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasNoticeOfPaymentSuspensionAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_AdvancedPayment"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("cra4qdJn+0u9lHvAG8KEfA#Value", "Notice of Payment Suspension"))],
_idProps: {
service: idService,
uuid: "403"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: "vertical-align margin-left-xl",
visible: true,
_idProps: {
service: idService,
uuid: "404"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasPaymentSupplementAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasPaymentSupplementAttr = value;
}),
_idProps: {
service: idService,
name: "Switch_PaymentSupplement"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("kaXxWr_VRUyo_8VbSsOKmQ#Value", "Payment Supplement"))],
_idProps: {
service: idService,
uuid: "406"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "407"
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
uuid: "408",
alias: "76"
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
uuid: "409"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Dropdown_PaymentMethodId2",
_idProps: {
service: idService,
uuid: "410"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5b8yE4WMskSydGCv_OKL+w#Value", "Payment Method"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("E_FoFXmOakuxhkTgP5xnOw#ValueExpression.722673599.1", "Select payment method"),
enabled: model.variables.l_CanEditAccountingVar,
labels: function (elem) {
return elem.descriptionAttr;
},
list: model.variables.getPaymentMethodsBySupplierIdDataAct.listOut,
mandatory: true,
style: "no-margin",
values: function (elem) {
return elem.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentMethodId2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
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
uuid: "412"
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
uuid: "413"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pBP1I02QWUm7lQGHvGH0Dg#Value", "Payment Terms"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OHDcpmZvH0erjZvuTvOrbw#ValueExpression.1491920553.1", "Select Payment Terms"),
enabled: model.variables.l_CanEditAccountingVar,
labels: function (elem) {
return elem.paymentTermsAttr.descriptionAttr;
},
list: model.variables.getPaymentTermsAggr.listOut,
mandatory: true,
style: "no-margin",
values: function (elem) {
return elem.paymentTermsAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr, function (value) {
model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown_PaymentTermsId2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaymentTermsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.listOut), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr)]
}), $if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (ConectaProveedores_staticEntities_currency.mXN)) && ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "415"
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
ExtendedClass: "margin-top-m"
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
uuid: "416",
alias: "77"
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
uuid: "417",
alias: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel",
visible: model.getCachedValue(idService.getId("GnP1q8svC06fJfGa6zFKpw.Visible"), function () {
return (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (ConectaProveedores_staticEntities_currency.mXN)) && ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr;
}),
_idProps: {
service: idService,
uuid: "418"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_NegotiatedExchangeRate_Accounting2",
_idProps: {
service: idService,
uuid: "419"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("d2HFoCzch0KlzCkdL_KsCw#Value", "Exchange Rate"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
prompt: "N/A",
style: "form-control no-margin",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr = value;
}),
_idProps: {
service: idService,
name: "Input_NegotiatedExchangeRate_Accounting2"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_NegotiatedExchangeRate_Accounting2"),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
SuffixText: "",
RightAlign: true,
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
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "421",
alias: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr)),
_idProps: {
service: idService,
uuid: "422"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr, model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Valid: model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr,
_i_ValidInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_IsEnabled: model.variables.l_CanEditAccountingVar,
i_File: model.getCachedValue(idService.getId("FfYOiLRiwkSpq8fRT5W7Wg.i_File"), function () {
return function () {
var rec = new ST_a158c76eb93396680623c04244f48b6cStructure();
rec.nameAttr = model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr;
rec.binaryDataAttr = model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr;
return rec;
}();
}, function () {
return model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr;
}, function () {
return model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr;
}),
_i_FileInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_FilesMaxSize: 20971520,
i_IsMandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))),
_i_IsMandatoryInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("e0hg+zQ38EO8fsnAPRs7oQ#Value.447611511.1", "Evidence")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(new ST_1d6498da9105fbe815a7f766352917c0Structure(), new ST_f9f8b40f5330871047e55e068d129447Structure(), true, false, false, false, false, false, false, true, false, false, false, false, controller.callContext(eventHandlerContext));

;
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomUploadOnFileChange$Action(fileIn, errorIn, false, false, false, false, false, false, false, true, false, false, false, false, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "423",
alias: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr)]
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "os-boxlabel custom-textarea",
visible: !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr)),
_idProps: {
service: idService,
uuid: "424"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr, model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))),
targetWidget: "TextArea_ExchangeRateComment2",
_idProps: {
service: idService,
uuid: "425"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}, $text(getTranslation("lvhc6zBLOkG5xUVtdLIrcg#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: model.variables.l_CanEditAccountingVar,
extendedProperties: {
style: "margin-bottom: unset;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && !(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr.equals(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr))),
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zlAEoZSgUUW7mENhZKVDoQ#ValueExpression.-1679915457.1", "Comment"),
style: "\"form-control\"",
textLines: 1,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr, function (value) {
model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_ExchangeRateComment2"
},
_widgetRecordProvider: widgetsRecordProvider,
mandatory_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr, model.variables.getAccountingDataDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getAccountingDataDataAct.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr)]
}))];
}, function () {
return [];
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "427"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align display-flex margin-top-m justify-content-space-between",
visible: true,
_idProps: {
service: idService,
uuid: "428"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
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
uuid: "429"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7Oiw3AV+C0+iByOtj_xoWg#Value", "Close"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
style: "text-align-right display-flex align-items-center",
visible: model.variables.l_AllowActionsVar,
_idProps: {
service: idService,
uuid: "430"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel width-auto white-space-nowrap",
visible: model.getCachedValue(idService.getId("gldHzYrFmUSBH09UM5PHeg.Visible"), function () {
return (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved)) || ((model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.modify)) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()))) && !(model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr;
}, function () {
return model.variables.i_RequisitionIdIn;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}),
_idProps: {
service: idService,
uuid: "431"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("l0H3yX77BEmYPP7zvltz8A#Value", "Cancel"))), createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn white-space-nowrap",
visible: model.getCachedValue(idService.getId("ooN6G1EyuEKaQelmxHg03A.Visible"), function () {
return (((model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()))) || ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.modify) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId()))) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved)));
}, function () {
return model.variables.i_RequisitionIdIn;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr;
}),
_idProps: {
service: idService,
uuid: "432"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("KXNGHTZhV0aCjgw3o4yiPw#Value", "Save"))), createElement(OSWidgets$Button, {
enabled: ((!(model.variables.l_IsBusyVar)) && (((((((((((((((((model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr && model.variables.getAccountingDataTypesAggr.isDataFetchedAttr) && model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr) && model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr) && model.variables.getCostCentersAggr.isDataFetchedAttr) && model.variables.getCurrenciesAggr.isDataFetchedAttr) && model.variables.getDepositTypesAggr.isDataFetchedAttr) && model.variables.getDistributionsAggr.isDataFetchedAttr) && model.variables.getFrequenciesAggr.isDataFetchedAttr) && model.variables.getInsuranceTypesAggr.isDataFetchedAttr) && model.variables.getInvoiceUsagesAggr.isDataFetchedAttr) && model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr) && model.variables.getProjectAssetServicesAggr.isDataFetchedAttr) && model.variables.getRequisitionByIdAggr.isDataFetchedAttr) && model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr) && model.variables.getServiceFormatsAggr.isDataFetchedAttr) && model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr) && model.variables.getSustainabilitiesAggr.isDataFetchedAttr)),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.captureOnClick$Action(OS$BuiltinFunctions.nullTextIdentifier(), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), false, controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-primary white-space-nowrap margin-right-5px",
visible: model.getCachedValue(idService.getId("W2WfBbXco0ynLatLspuwpg.Visible"), function () {
return (model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || (((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.modify)) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr === OS$BuiltinFunctions.getUserId())));
}, function () {
return model.variables.i_RequisitionIdIn;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr;
}),
_idProps: {
service: idService,
uuid: "433"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Capturar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "434"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("CZso2+f6EEKdrOLIrb5j4g#Value", "Finalize Capture"))],
_idProps: {
service: idService,
uuid: "435"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsBusyVar)),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideModifyPopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-edit width-auto white-space-nowrap",
visible: ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved)),
_idProps: {
service: idService,
uuid: "436"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 20px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_EditBlue.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "437"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("B15uAYN7UUeWdpSWItnUIQ#Value", "Modify"))],
_idProps: {
service: idService,
uuid: "438"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Button, {
enabled: ((!(model.variables.l_IsBusyVar)) && (((((((((((((((((((model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr && model.variables.getAccountingDataTypesAggr.isDataFetchedAttr) && model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr) && model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr) && model.variables.getCostCentersAggr.isDataFetchedAttr) && model.variables.getCurrenciesAggr.isDataFetchedAttr) && model.variables.getDepositTypesAggr.isDataFetchedAttr) && model.variables.getDistributionsAggr.isDataFetchedAttr) && model.variables.getFrequenciesAggr.isDataFetchedAttr) && model.variables.getInsuranceTypesAggr.isDataFetchedAttr) && model.variables.getInvoiceUsagesAggr.isDataFetchedAttr) && model.variables.getPaymentWaysAggr.isDataFetchedAttr) && model.variables.getPaymentOptionsAggr.isDataFetchedAttr) && model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr) && model.variables.getProjectAssetServicesAggr.isDataFetchedAttr) && model.variables.getRequisitionByIdAggr.isDataFetchedAttr) && model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr) && model.variables.getServiceFormatsAggr.isDataFetchedAttr) && model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr) && model.variables.getSustainabilitiesAggr.isDataFetchedAttr)),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.approve$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-approve width-auto white-space-nowrap",
visible: ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.inApproval) && (model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notApproved)),
_idProps: {
service: idService,
uuid: "439"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.ApproveIcon.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "440"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if((((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.currentLevelAttr === model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.maxLevelAttr) && model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr) && ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("8PS2DkAfwU28p3KUUqDUlw#Value", "Finalize"))],
_idProps: {
service: idService,
uuid: "441"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("vi6LlkkB2USmqZc1hRwFYA#Value", "Approve"))],
_idProps: {
service: idService,
uuid: "442"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))), $if((model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "443"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.seeLogsOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "444"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "445"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("3bS6S2RyaUiMHy3abriVJQ#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "446"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}), createElement(OutSystemsUI_Interaction_Sidebar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Width: "700"
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
name: "SidebarLog",
alias: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "448"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "449",
alias: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
visible: true,
_idProps: {
service: idService,
uuid: "450"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dpuilj6HnE6GClKJjN409Q#Value", "Historic"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "451"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeSidebar$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "452"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "453"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_RequisitionLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RequisitionId: model.variables.i_RequisitionIdIn,
i_refresh: model.variables.l_RefreshSideBarVar
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
uuid: "454",
alias: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.i_RequisitionIdIn)]
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.l_IsBusyVar), asPrimitiveValue(model.variables.l_AllowActionsVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.listOut), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.l_CanSeeAdvanceWithOrWithoutInvoiceVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasPaymentSupplementAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasNoticeOfPaymentSuspensionAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.hasFetchErrorAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_NotValidPaymentsValueVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.l_OriginalDateOfCommitmentVar), asPrimitiveValue(model.variables.l_ShowSavePendingInfoBtnVar), asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.l_NotValidContractValueVar), asPrimitiveValue(model.variables.l_RetentionPercentageListVar), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.validAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.listOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getPaymentWaysAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.listOut), asPrimitiveValue(model.variables.getPaymentOptionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.listOut), asPrimitiveValue(model.variables.getSustainabilitiesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.listOut), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.listOut), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.projectAssetMaxRecordVar), asPrimitiveValue(model.variables.getShowIsDonationDataAct.o_ShowOut), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.l_DropdownSupplierValidVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDistributionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getShowIsDonationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.maxLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.currentLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectDescriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr)]
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "455",
alias: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "456"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr === ConectaProveedores_staticEntities_requisitionStatus.approved), false, this, function () {
return [createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RequisitionId: model.variables.i_RequisitionIdIn
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
uuid: "457",
alias: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.l_IsBusyVar), asPrimitiveValue(model.variables.l_AllowActionsVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.listOut), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.l_CanSeeAdvanceWithOrWithoutInvoiceVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasPaymentSupplementAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasNoticeOfPaymentSuspensionAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.hasFetchErrorAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_NotValidPaymentsValueVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.l_OriginalDateOfCommitmentVar), asPrimitiveValue(model.variables.l_ShowSavePendingInfoBtnVar), asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.l_NotValidContractValueVar), asPrimitiveValue(model.variables.l_RetentionPercentageListVar), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.validAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.listOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getPaymentWaysAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.listOut), asPrimitiveValue(model.variables.getPaymentOptionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.listOut), asPrimitiveValue(model.variables.getSustainabilitiesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.listOut), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.listOut), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.projectAssetMaxRecordVar), asPrimitiveValue(model.variables.getShowIsDonationDataAct.o_ShowOut), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.l_DropdownSupplierValidVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDistributionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getShowIsDonationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.maxLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.currentLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectDescriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "458"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("cfrNxFcewUqgRMyJhUYJPA.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
rec.justifyHeadersAttr = true;
return rec;
}();
})
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
uuid: "459",
alias: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "460",
alias: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
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
uuid: "461",
alias: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_buscar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "462"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("e_VKk0z_2EqzAGLM1FPFNQ#Value", "Supplier"))];
})
},
_dependencies: []
})];
})
},
_dependencies: []
}), $if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "463",
alias: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("m8+1J7w4A0u4vBOnWxMq5w#Value", "Applicant"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "464",
alias: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_c_Requisitions_Wb_SearchSupplier_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsEnabled: model.getCachedValue(idService.getId("kx39ti3vTky503640dphWw.IsEnabled"), function () {
return ((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr === ConectaProveedores_staticEntities_requisitionStatus.dataCapture) || model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())));
}, function () {
return model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr;
}, function () {
return model.variables.i_RequisitionIdIn;
}),
_isEnabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
RequisitionId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr,
_requisitionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
SupplierId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr,
_supplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
event$Action: function (supplierIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.event_ChangeSupplier$Action(supplierIdIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "465",
alias: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr)]
}), $if((!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
uuid: "466",
alias: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "467"
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
name: "FormApplicant"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "469"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Applicant",
_idProps: {
service: idService,
uuid: "470"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("deG2wnNv5Ua+0Lcr0K4XcQ#Value", "Applicant"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("FormApplicant")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 256,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lcmqkcwoA0yXNxF1gWj1nQ#ValueExpression.-86032670.1", "Applicant"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr, function (value) {
model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Applicant"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "472"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Society",
_idProps: {
service: idService,
uuid: "473"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("asIy8zlXjUOvhiWl4o6SeA#Value", "Society"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("FormApplicant")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 10,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GyNVxo+J5k+l6F4N42JTGw#ValueExpression.-374112632.1", "Society"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.centroRTPAttr, function (value) {
model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.centroRTPAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Society"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "475"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Department",
_idProps: {
service: idService,
uuid: "476"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UzQ9JKWxKE6d2k8iSoxEaA#Value", "Department"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("FormApplicant")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 200,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iwCl9h_QqkqbzmQYDJXOdQ#ValueExpression.-1453318286.1", "Department"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr, function (value) {
model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Department"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "478"
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
uuid: "479"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("BoZ7dSkiBUKn3YdznnhXDw#Value", "Region"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("FormApplicant")
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ONCyZZNIXkqTkwuqLp56og#ValueExpression.-1850928364.1", "Region"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr, function (value) {
model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Region"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-bottom: unset"
},
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "481"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Email",
_idProps: {
service: idService,
uuid: "482"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fnWfA2wek0uijAIX1ZkzXg#Value", "Email"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("FormApplicant")
},
enabled: false,
extendedProperties: {
style: "margin-bottom: unset"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Email*/ 7,
mandatory: true,
maxLength: 256,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DQADs9kBcEOwFjZqjJCi8w#ValueExpression.67066748.1", "Email"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Email, model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr, function (value) {
model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Email"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.centroRTPAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)]
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.centroRTPAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr)]
})), $if(((!(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.getRequisitionByIdAggr.isDataFetchedAttr) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))), false, this, function () {
return [createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RequisitionId: model.variables.i_RequisitionIdIn,
i_RefreshWB: model.variables.l_RefreshRequisitionEntra_HistoricVar
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
uuid: "484",
alias: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshRequisitionEntra_HistoricVar), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.centroRTPAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.l_IsBusyVar), asPrimitiveValue(model.variables.l_AllowActionsVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.listOut), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.l_CanSeeAdvanceWithOrWithoutInvoiceVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasPaymentSupplementAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasNoticeOfPaymentSuspensionAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.hasFetchErrorAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_NotValidPaymentsValueVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.l_OriginalDateOfCommitmentVar), asPrimitiveValue(model.variables.l_ShowSavePendingInfoBtnVar), asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.l_NotValidContractValueVar), asPrimitiveValue(model.variables.l_RetentionPercentageListVar), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.validAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.listOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.getPaymentWaysAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.listOut), asPrimitiveValue(model.variables.getPaymentOptionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.listOut), asPrimitiveValue(model.variables.getSustainabilitiesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.listOut), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.listOut), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.projectAssetMaxRecordVar), asPrimitiveValue(model.variables.getShowIsDonationDataAct.o_ShowOut), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.l_DropdownSupplierValidVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDistributionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getShowIsDonationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.maxLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.currentLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectDescriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr), asPrimitiveValue(model.variables.i_IsUploadInvoiceIn)]
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowCancelPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Cancel"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr) !== (ConectaProveedores_staticEntities_requisitionStatus.dataCapture)), false, this, function () {
return [createElement(ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsCancel: true,
i_RequisitionId: model.variables.i_RequisitionIdIn,
i_RequisitionApprovalLevelId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.idAttr,
_i_RequisitionApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(controller.callContext(eventHandlerContext));

;
},
action$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cancelRequisition$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "486",
alias: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("A3Gm6Coyh0CUJHg7pWS+IA#Value.-602822666.1", "Cancel Requisition"),
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("UZnE8su7BEK8bAV5ZiFQsw#Value.-417569474.1", "Are you sure you want to cancel the requisition? This action is irreversible.")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.cancelRequisition$Action(true, controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "487",
alias: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowModifyPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "Modify"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsCancel: false,
i_RequisitionApprovalLevelId: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.idAttr,
_i_RequisitionApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr),
i_RequisitionId: model.variables.i_RequisitionIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
action$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.modifyRequisition$Action(controller.callContext(eventHandlerContext));

;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideModifyPopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "489",
alias: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowHideSelectReqRegion_PopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "SelectRegion"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_mvc_view, {
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
select$Action: function (i_RegionIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_SelectReqRegion_PopupSelect$Action(i_RegionIdIn, controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideSelectReqRegion_Popup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "491",
alias: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); min-width: 600px;"
},
showPopup: model.variables.l_ShowAssignFirstApproverPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "SelectFirstApprover"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_mvc_view, {
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
selectUser$Action: function (userIdSelectedIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.captureOnClick$Action(userIdSelectedIn, OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), false, controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideAssignFirstApproverPopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "493",
alias: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base); min-width: 600px;"
},
showPopup: model.variables.l_ShowHideSpecialOrNormalWorkflowVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "SpecialOrNormalWorkflow"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ProcessTypeCode: "REQ",
IsDonation: model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr,
_isDonationInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
selectWorkflow$Action: function (i_ApprovalProcessIdIn, i_FirstApproverUserIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.captureOnClick$Action(i_FirstApproverUserIdIn, i_ApprovalProcessIdIn, i_ApprovalProcessIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), controller.callContext(eventHandlerContext));
});
;
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideSpecialOrNormalWorkflowPopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "495",
alias: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
footer: new Widget.PlaceholderContent(function () {
return [$if((((((((((((((((((((((model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr && model.variables.getAccountingDataTypesAggr.isDataFetchedAttr) && model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr) && model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr) && model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.isDataFetchedAttr) && model.variables.getCostCentersAggr.isDataFetchedAttr) && model.variables.getCurrenciesAggr.isDataFetchedAttr) && model.variables.getDepositTypesAggr.isDataFetchedAttr) && model.variables.getDistributionsAggr.isDataFetchedAttr) && model.variables.getFrequenciesAggr.isDataFetchedAttr) && model.variables.getInsuranceTypesAggr.isDataFetchedAttr) && model.variables.getInvoiceUsagesAggr.isDataFetchedAttr) && model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr) && model.variables.getProjectAssetServicesAggr.isDataFetchedAttr) && model.variables.getRequisitionByIdAggr.isDataFetchedAttr) && model.variables.getRequisitionCostCentersByRequisitionIdAggr.isDataFetchedAttr) && model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr) && model.variables.getServiceFormatsAggr.isDataFetchedAttr) && model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr) && model.variables.getSupplierByRequisitionAggr.isDataFetchedAttr) && model.variables.getSustainabilitiesAggr.isDataFetchedAttr) && model.variables.getUserByIdAggr.isDataFetchedAttr), false, this, function () {
return [];
}, function () {
return [];
}), createElement(AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
EveryMilliseconds: 2000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
eventFromJS$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_CurrencyOnChange$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "496",
alias: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRequisitionCostCentersByRequisitionIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_ShowHideSpecialOrNormalWorkflowVar), asPrimitiveValue(model.variables.l_ShowAssignFirstApproverPopupVar), asPrimitiveValue(model.variables.l_ShowHideSelectReqRegion_PopupVar), asPrimitiveValue(model.variables.l_ShowModifyPopupVar), asPrimitiveValue(model.variables.l_ShowCancelPopupVar), asPrimitiveValue(model.variables.l_RefreshRequisitionEntra_HistoricVar), asPrimitiveValue(model.variables.getUserByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).departmentAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.centroRTPAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.l_IsBusyVar), asPrimitiveValue(model.variables.l_AllowActionsVar), asPrimitiveValue(model.variables.getPaymentTermsAggr.listOut), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.listOut), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.listOut), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.listOut), asPrimitiveValue(model.variables.l_CanSeeAdvanceWithOrWithoutInvoiceVar), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.rEPSEOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.validAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.binaryAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.exchangeRateEvidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasPaymentSupplementAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasNoticeOfPaymentSuspensionAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasREPSEAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.exchangeRateCommentAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.negociatedExchangeRateAccAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.specialPostDeliveryAuthIdAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.requisitionAccountingOut.hasSpecialPostDeliveryAuthAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_RemainingOut), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.subAccConceptsAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.o_Estim_Equal_AgreedOut.mainAccConceptAttr.isActiveAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.hasFetchErrorAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_NotValidPaymentsValueVar), asPrimitiveValue(model.variables.getEntraRoleAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.isAreaCxPAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.listOut), asPrimitiveValue(model.variables.getDepositTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.listOut), asPrimitiveValue(model.variables.l_OriginalDateOfCommitmentVar), asPrimitiveValue(model.variables.l_ShowSavePendingInfoBtnVar), asPrimitiveValue(model.variables.getConfigurationDataAct.uploadContractDateLimitOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractAdvancePaymentOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractInsuranceListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractDepositListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_AttachFilesListOut), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractFileOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.validAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.o_ContractPendingJustificationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.l_NotValidContractValueVar), asPrimitiveValue(model.variables.l_RetentionPercentageListVar), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.validAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_ProofOfForeignResidenceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.binaryAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.o_FinanceAuthorizationOut.validAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.listOut), asPrimitiveValue(model.variables.getPaymentWaysAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.listOut), asPrimitiveValue(model.variables.getPaymentOptionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.listOut), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.listOut), asPrimitiveValue(model.variables.getSustainabilitiesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.listOut), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.listOut.getCurrent(callContext.iterationContext).costCenterSAPAttr.denominacionAttr), asPrimitiveValue(model.variables.getCostCentersAggr.listOut), asPrimitiveValue(model.variables.getCostCentersAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getDistributionsAggr.listOut), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.listOut), asPrimitiveValue(model.variables.getFrequenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.listOut), asPrimitiveValue(model.variables.l_CanEditAccountingVar), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.listOut), asPrimitiveValue(model.variables.l_NotValidVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveServiceTypeEXP1Out), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.listOut), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.idAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).project_Asset_ServiceAttr.descriptionAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.listOut), asPrimitiveValue(model.variables.projectAssetMaxRecordVar), asPrimitiveValue(model.variables.getShowIsDonationDataAct.o_ShowOut), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.listOut), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.idAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.l_DropdownSupplierValidVar), asPrimitiveValue(model.variables.l_CanEditUserAreaVar), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.binaryAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.storageIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionFileAttr.filenameAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.validAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.currencyIdAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.amountAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.o_AdvWithoutInvoiceOut.requisitionContractFileAttr.advancePaymentTypeIdAttr), asPrimitiveValue(model.variables.i_IsUploadInvoiceIn), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentTermsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentMethodsBySupplierIdDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSpecialPostDeliveryAuthorizationsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getEntraRoleAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInsuranceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDepositTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getConfigurationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionContractDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getServiceFormatsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentWaysAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaymentOptionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueSubcategoriesByCategoryIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getBusinessValueCategoriesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSustainabilitiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCenterSAPByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCostCentersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getDistributionsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoiceUsagesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFrequenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAccountingAccountsServiceTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionServicesByRequisitionIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServiceOtroAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getShowIsDonationDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierSocietiesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvancedPaymentTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierByRequisitionAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getAdvWithoutInvoiceDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.maxLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.currentLevelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalAttr.hasStartedAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.assignedToAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionApprovalLevelAttr.isAccountingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentTermsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentMethodIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasAdvancePaymentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasInsuranceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasDepositAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasUpdatedDateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractFileUploadedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.createdOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.submittedOnAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.dateOfCommitmentAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isContractPendingAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.retentionRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.negotiatedExchangeRateAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.currencyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.applicantIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.requisitionStatusIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.serviceFormatIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentWaysIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.paymentOptionsIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueSubcategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.businessValueCategoryIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.sustainabilityIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isSustainabilityAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.costCenterIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.distributionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.totalAmountAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectDescriptionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.projectAssetServiceIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isDonationAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocPositionAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.buyDocNumberAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.companyIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.advWithoutInvoiceAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.hasContractAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.supplierIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.regionIdAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.nameAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionAttr.isAdvancedAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.idAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.classAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.listOut.getCurrent(callContext.iterationContext).requisitionStatusAttr.labelAttr), asPrimitiveValue(model.variables.getRequisitionByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.i_RequisitionIdIn)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "RequisitionDetail",
functionKey: "e5f3202b-7d20-4fff-aac0-83474f367899",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.RequisitionDetail",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.c_Requisitions.RequisitionDetail.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Adaptive_Columns4_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, InputMasks_InputMaskReactFlow_MaskText_mvc_view, ConectaProveedores_y_Utils_Wb_SearchDropdown_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, BigUpload_BigUpload_wb_BigUploadSingleFile_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, ConectaProveedores_y_Logs_Wb_RequisitionLogs_mvc_view, ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_mvc_view, ConectaProveedores_c_Requisitions_Wb_SearchSupplier_mvc_view, ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_mvc_view, ConectaProveedores_c_Requisitions_Wb_ReqCancelModif_Popup_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, ConectaProveedores_c_Requisitions_Wb_SelectReqRegion_Popup_mvc_view, ConectaProveedores_c_Requisitions_Wb_AssignFirstApproverPopup_mvc_view, ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_mvc_view, AutoRefreshUtils_Widget_EventExtensibilityBlock_mvc_view];
};


return ELEM;
};

export default componentFactory()
