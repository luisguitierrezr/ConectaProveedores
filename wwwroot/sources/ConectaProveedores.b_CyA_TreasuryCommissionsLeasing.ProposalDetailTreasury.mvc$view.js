import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Button as OSWidgets$Button, Icon as OSWidgets$Icon, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_trigger as ConectaProveedores_staticEntities_trigger, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$view.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_view from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpayPaymentPopup.mvc$view.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_mvc_view from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
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
Initiative: "CYA",
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
text: [$text(getTranslation("sahMdn5qr0qDz3nFYMc+ow#Value", "Homepage"))],
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
text: [$text(getTranslation("TMj3C5LA1UiPlqZhowLmOA#Value", "Dashboard"))],
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
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsTreasury", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("g+9oxZB_ZkSL82K4o4xhVA#Value", "Proposals"))],
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
text: [$text(getTranslation("tVSMxVkSNUmLALfYZs5hIw#Value", "Payment Proposal"))],
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
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
GutterSize: ConectaProveedores_staticEntities_gutterSize.medium
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "18",
alias: "3"
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
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("0JK0gd9iF0C+a1S3Cm_PaQ#Value", "Payment Proposal"))],
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "ContainerStatusTitle",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr),
i_Text: model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
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
uuid: "23",
alias: "4"
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "italic",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "text-secondary font-bold",
value: ("#" + model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("qvN_kF4kFUyWnXxbGHMnsw.Value"), function () {
return (((" " + (((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr === OS$BuiltinFunctions.nullTextIdentifier())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jwXpOlaVSUG0Wh6p4ZavvA#ValueExpression.-1729748102.1", "Automatic Import")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jwXpOlaVSUG0Wh6p4ZavvA#ValueExpression.1745413439.1", "Manual Import")))) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}),
column2: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [$if(((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.nullTextIdentifier()) || (((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr) !== (OS$BuiltinFunctions.getUserId())) && (((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr) !== (ConectaProveedores_staticEntities_proposalStatus.paid)) || (((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid) && (!(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.equals(OS$BuiltinFunctions.nullDate())) && OS$BuiltinFunctions.currDate().lte(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr))) || false)))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.variables.l_ClaimEnableVar,
extendedProperties: {
style: "width: fit-content;"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.claimProposal$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "font-size: 24px; color: #fff;"
},
icon: "lock",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("1y4orDzj6kqqWgrBup5lcA#Value", "Claim"))],
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "35"
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
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
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
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Filename",
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mqOSXqeOVE+S9m1MkMylPw#Value", "Document"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "39",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadFile$Action(controller.callContext(eventHandlerContext));
});
;
}
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excel.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 200,
prompt: "TELCEL_COMISIONES_R#_BANCO_BC###_AAAAMMDD.xlsx",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Filename"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_ProposalType",
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IAbHU54ANkq3GgIMIvXcDQ#Value", "Type"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("r8EGn7UVhEesz_htzwQcPg#ValueExpression.514673544.1", "Proposal type"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ProposalType"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "45"
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
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PaymentDate",
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("b6dws5VQSUSlrEK7xTSJiA#Value", "Payment Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "48",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_calendario.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vl9tNAOmKEu_OtwMjHcUAw#ValueExpression.-949970752.1", "DD/MM/AAAA"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.dateTextFormattedVar, function (value) {
model.variables.dateTextFormattedVar = value;
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.dateTextFormattedVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "51"
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "52",
alias: "7"
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
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Bank",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("toHJQt9yXkaaZmCxlfCrVg#Value", "Bank"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("mKO26gY5B0CEcvHzMAu_AQ#ValueExpression.-1315922686.1", "BBVA / Inbursa"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Bank"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
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
uuid: "56"
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
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7QUMUQaEkkezNah_uNap5w#Value", "Proposal Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 200,
prompt: "BC###",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr)]
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width9"
},
style: "os-boxlabel auto-width",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_l_PaymentStatus",
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("AEbGYri2LE2QW0i+8Y8zyA#Value", "Payment Status"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ww6JjWA4VkKuQPfa6nG3YQ#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.approvalStatusAttr.labelAttr;
},
list: model.variables.getApprovalStatusesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_l_PaymentStatusOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.approvalStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.l_PaymentStatusVar, function (value) {
model.variables.l_PaymentStatusVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_l_PaymentStatus"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId()) && ((!(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.currDate().lte(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr)) : (true))), false, this, function () {
return [$if(model.variables.i_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: ((model.variables.l_IsSelectAllVar === true) || (model.variables.l_IsSelectedVar === true)),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paySelectedOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn text-third",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "text-third margin-left-s",
text: [$text(getTranslation("1OJXbuC4HEqo3St4FPN80Q#Value", "Bulk Pay"))],
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
}, function () {
return [];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "68"
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
text: [$text(getTranslation("MASY+_aeDEWnvuhbd2tcUw#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
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
uuid: "72",
alias: "8"
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
source: model.variables.getProposalLinesByProposalIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresProposalDetailTreasuryGetProposa"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("5Kd+XsYB8kuFKJYj+9jPsg.style"), function () {
return ("text-align: center; " + ((((model.variables.i_IsShowSelectAllVar && (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId())) && ((!(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.currDate().lte(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr)) : (true)))) ? (" ") : (" display: none;")));
}, function () {
return model.variables.i_IsShowSelectAllVar;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.i_IsShowSelectAllVar)]
}, $if(model.variables.i_IsShowSelectAllVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsHorizontal: true
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
uuid: "76",
alias: "9"
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
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectAllLines$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_IsSelectAllVar, function (value) {
model.variables.l_IsSelectAllVar = value;
}),
_idProps: {
service: idService,
name: "Checkbox3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Cuenta",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jnafWWu1wEqlgb1NsiQaFw#Value", "Account"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Referencia",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SUCa+kzdf0i3k9Sp1t76eQ#Value", "Ref"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Nombre1",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0AcSPlSNlkqHvhdZWiYU9A#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.N_doc_",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("GJlFaNz2o0yYUZ2ZeES4BA#Value", "No. Doc."))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenML",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VcHnvYNfeEuovlYeOpffWw#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.ML",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3ha9V9TOVEek2OIuYY76vw#Value", "Currency ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenMD",
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XrorroSyKkmZs8DAfgEErw#Value", "Amount MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Mon_",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QiK+WaS5ukGlnD1oFMqLLw#Value", "Currency  MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Soc_",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Gv9XWmsOTU252iLlN4EmqQ#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Div_",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("w0a7n1YNg0iW2+yjBDEkhg#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("TUXISyRux0WEjd3FOAnHMg#Value", "Paid")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("ayWe6V7g70enYEJBtyCR+A.style"), function () {
return ((((model.variables.i_IsShowSelectAllVar && (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId())) && ((!(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (OS$BuiltinFunctions.currDate().lte(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr)) : (true)))) ? (" ") : (" display: none;"));
}, function () {
return model.variables.i_IsShowSelectAllVar;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr;
})
},
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr)]
}, $if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsHorizontal: true
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
uuid: "94",
alias: "10"
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
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.isAnyLineSelected$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr, function (value) {
model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).isSelectedAttr)]
}))];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr),
i_NChar: 15
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
uuid: "102",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Qdb5HNTqQEiJoyhlYfWLcQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr, 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr;
}),
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("_rh5iCVzckOqdOZIu51Ebw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr, 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr;
}),
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showDocumentLog$Action(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentAttr.idAttr)]
}, $if(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openUnpaidDetailPopup$Action(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_PaidAttr.nameAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_UnpaidAttr.nameAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr)]
}, $if(true, false, this, function () {
return [$if(((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId()) && (model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openUnpayPaymentPopup$Action(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
gridProperties: {
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Link, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.payOnClick$Action(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_exito.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [$if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notPaid), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId()), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Z9NUTo9dPUOTflPWIdwT8Q#Value.1241247687.1", "Mark as paid")
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.payOnClick$Action(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "font-size: 24px;"
},
icon: "undo",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
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
uuid: "137",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "user",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("77gmyD5MDkGANonujIKw_g#ValueExpression.3159.1", "by") + " ") + model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_UnpaidAttr.nameAttr),
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_UnpaidAttr.nameAttr)]
}))];
}, function () {
return [$if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.paid), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
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
uuid: "142",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "user",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("H_tkUf1IvEWX9QWXwLhcFA#ValueExpression.3159.1", "by") + " ") + model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_PaidAttr.nameAttr),
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_PaidAttr.nameAttr)]
}))];
}, function () {
return [];
})];
})];
})];
}, function () {
return [];
}))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr), asPrimitiveValue(model.variables.i_IsShowSelectAllVar)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TableName: idService.getId("ConectaProveedoresProposalDetailTreasuryGetProposa"),
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalDetailTreasuryVar,
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
PopupBtnId: idService.getId("OpenPopupLink")
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
uuid: "145",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalDetailTreasuryVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr), asPrimitiveValue(model.variables.i_IsShowSelectAllVar), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut)]
})), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getProposalLinesByProposalIdAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr),
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords()
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "146",
alias: "15"
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
return controller.paginationOnNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "147",
alias: "16"
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
uuid: "148"
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
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "150"
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
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("O46uoOWnk06_aGEtbzg6AA#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
})];
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
validationService: validationService
},
_idProps: {
service: idService,
name: "SidebarLog",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display",
visible: true,
_idProps: {
service: idService,
uuid: "157"
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "158",
alias: "18"
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
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dUHL1oEcv0WVDwbQgAnLeA#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "160"
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
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalLineId: model.getCachedValue(idService.getId("8yg43ddS_UyNv41YX+Y+dQ.i_ProposalLineId"), function () {
return OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}),
i_ProposalId: model.variables.i_ProposalIdIn,
i_refresh: model.variables.l_RefeshSideBarVar
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
uuid: "163",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn)]
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
validationService: validationService
},
_idProps: {
service: idService,
name: "SidebarDocumentLog",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display",
visible: true,
_idProps: {
service: idService,
uuid: "165"
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "166",
alias: "21"
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
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+ArQD4ed+ESI1bUfGgOCrw#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "168"
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
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
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
}, createElement(OSWidgets$Expression, {
value: model.variables.l_SelectdLogDocumentNumberVar,
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_refresh: model.variables.l_RefeshDocumentSideBarVar,
i_ProposalLineId: model.variables.l_SelectdLogDocumentIdVar,
i_ProposalId: model.variables.i_ProposalIdIn
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
uuid: "173",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 24px;"
},
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oBC82ITbgk6LvcXmF02SUg#Value", "Amount"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card card-monto margin-top-xl",
visible: true,
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("+5x15mGJ9kK5P5JJqijYrg.Value"), function () {
return ((("(" + model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr) + ") ") + OS$BuiltinFunctions.formatCurrency(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ","));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("+yjmdpEg4kGkVWYCxtEDpA#Value", "Proposal Lines"))],
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7",
value: (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr).toString(),
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalDetailTreasuryVar), asPrimitiveValue(model.variables.l_IsSelectedVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.i_IsShowSelectAllVar), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(model.variables.l_PaymentStatusVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.dateTextFormattedVar), asPrimitiveValue(model.variables.l_ClaimEnableVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowUnpayPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalLineIdToUnpayPayment: model.variables.l_ProposalLineIdForPopupVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideUnpayPaymentPopup$Action(controller.callContext(eventHandlerContext));

;
},
unpay$Action: function (hasProposalChangedStatusIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_RejectPaymentPopupReject$Action(hasProposalChangedStatusIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "185",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowUnpaidDetailPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalLineId: model.variables.l_ProposalLinelIdUnpaidDetailVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideUnpaidPopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "187",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_ProposalLinelIdUnpaidDetailVar), asPrimitiveValue(model.variables.l_ShowUnpaidDetailPopupVar), asPrimitiveValue(model.variables.l_ProposalLineIdForPopupVar), asPrimitiveValue(model.variables.l_ShowUnpayPopupVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalDetailTreasuryVar), asPrimitiveValue(model.variables.l_IsSelectedVar), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.i_IsShowSelectAllVar), asPrimitiveValue(model.variables.getApprovalStatusesAggr.listOut), asPrimitiveValue(model.variables.l_PaymentStatusVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.dateTextFormattedVar), asPrimitiveValue(model.variables.l_ClaimEnableVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.maxDatePaymentChangesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalDetailTreasury",
functionKey: "f50fc5fd-e031-4c26-b69d-2d354c16eb71",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.ProposalDetailTreasury.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpayPaymentPopup_mvc_view, ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
