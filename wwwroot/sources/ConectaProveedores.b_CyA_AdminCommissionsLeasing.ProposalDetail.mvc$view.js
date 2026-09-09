import { withBaseWebScreen, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Label as OSWidgets$Label, Input as OSWidgets$Input, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Icon as OSWidgets$Icon, Dropdown as OSWidgets$Dropdown, Button as OSWidgets$Button, List as OSWidgets$List, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus, SE_trigger as ConectaProveedores_staticEntities_trigger, SE_position as ConectaProveedores_staticEntities_position, SE_steps as ConectaProveedores_staticEntities_steps } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import { ST_d1e6f35068707165b6684293e397ea3bStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_TimelineStatus_mvc_view from "./ConectaProveedores.y_Utils.Wb_TimelineStatus.mvc$view.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_mvc_view from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.Wb_ProposalCanceledMotive.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_mvc_view from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.Wb_RejectedCommentTooltip.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$view.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$view.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$view.js";
import ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_mvc_view from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.Wb_CancelProposalPopup.mvc$view.js";
import ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_mvc_view from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.mvc$controller.js";
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
ChatBotIsEnable: true,
Initiative: "CYA"
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
text: [$text(getTranslation("mgEyG0G9ZkSm5WvKuk3AxQ#Value", "Homepage"))],
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
text: [$text(getTranslation("H5cTa2dYuESTnXRGKFz0VQ#Value", "Dashboard"))],
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
}, $if(ConectaProveedoresController$default.checkComissionesArrendamientosViewerRole$Action(callContext).hasRoleOut, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsListViewer", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("LFE2eE8LR0C5tiegXdlIBQ#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}),
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("aIkaKxeLQ0GrH9bdkSN8og#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})), createElement(OSWidgets$Image, {
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
uuid: "16"
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
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("v3uXCwVn_kmBSnebiCU7xQ#Value", "Payment Proposal"))],
_idProps: {
service: idService,
uuid: "18"
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
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
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
uuid: "19",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative ",
visible: true,
_idProps: {
service: idService,
uuid: "20"
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
uuid: "21",
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
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("gl6tnacEAEKyv1isCNqr5A#Value", "Payment Proposal"))],
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "ContainerStatusTitle",
visible: true,
_idProps: {
service: idService,
uuid: "25"
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
uuid: "26",
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
uuid: "27"
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
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "text-secondary font-bold",
value: ("#" + model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("QzYb+D19J0Wu2kJD1ZeJzg.Value"), function () {
return (((" " + (((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr === OS$BuiltinFunctions.nullTextIdentifier())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("klcXJhzVI0iivrNluBvsvw#ValueExpression.-1729748102.1", "Automatic Import")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("klcXJhzVI0iivrNluBvsvw#ValueExpression.1745413439.1", "Manual Import")))) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr;
}),
_idProps: {
service: idService,
uuid: "30"
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
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getProposalByIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_TimelineStatus_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StepList: model.getCachedValue(idService.getId("VCwAJdZvgkS5pF9+s8H9mg.StepList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getProposalStatusesAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_d1e6f35068707165b6684293e397ea3bStructure))(), function (source, target) {
target.orderAttr = source.proposalStatusAttr.orderAttr;
target.labelAttr = source.proposalStatusAttr.labelAttr;
target.extendedClassAttr = (((source.proposalStatusAttr.orderAttr === model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.orderAttr)) ? (source.proposalStatusAttr.classAttr) : (""));
return target;
});
}, function () {
return model.variables.getProposalStatusesAggr.listOut;
}),
_stepListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalStatusesAggr.dataFetchStatusAttr)
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
uuid: "33",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalStatusesAggr.listOut), asPrimitiveValue(model.variables.getProposalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getProposalByIdAggr.isDataFetchedAttr && model.variables.getProposalStatusesAggr.isDataFetchedAttr), false, this, function () {
return [$if((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.canceled), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
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
uuid: "36",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "38"
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
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
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
targetWidget: "Input_Filename",
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Ca+wZrYbE0C+eq2CdwODnQ#Value", "Document"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
alias: "7"
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
uuid: "45"
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
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fTurMO3aaUm8xy_I2e5Miw#Value", "Type"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4iM6RsrKEkCF0jpCOTtouA#ValueExpression.514673544.1", "Proposal type"),
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
uuid: "48"
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
uuid: "49"
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
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("cPou22LXh0ileHo4M_XCug#Value", "Payment Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "51",
alias: "8"
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
uuid: "52"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("wntX1TRLjUG4QjR45DZxVQ#ValueExpression.-949970752.1", "DD/MM/AAAA"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_DateTextFormattedVar, function (value) {
model.variables.l_DateTextFormattedVar = value;
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_DateTextFormattedVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
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
validationService: validationService
},
_idProps: {
service: idService,
uuid: "55",
alias: "9"
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
uuid: "56"
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
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("13JEfSykKUCeqM4YMDVv_w#Value", "Bank"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Y39xL1_Uok6wkx08Hn+oZw#ValueExpression.-1315922686.1", "BBVA / Inbursa"),
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
uuid: "59"
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
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("CXESUdgHn0KfUm7Uh2xirg#Value", "Proposal Name"))), createElement(OSWidgets$Input, {
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
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr, false, this, function () {
return [$if(((((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.approved) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.beingPaid)) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "63"
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
uuid: "64",
alias: "10"
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
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Cuenta",
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("TaKjjV7Vm0WGs+BUIcBePw#Value", "Account"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Referencia",
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("I0zAx7qJRECgo7j5L4RfOg#Value", "Ref"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Nombre1",
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("tniOg95A4UiUVpI0pGGKzw#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.N_doc_",
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("y+OAxYNDhUSe8hlLEIt1OQ#Value", "No. Doc."))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenML",
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pieJb03zDU6WnYHCANJlyg#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.ML",
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QmemPWiE2UK5lBFhLkLTbA#Value", "Currency ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenMD",
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rzFrOMaqc0yqtG8VJmTsjw#Value", "Amount MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Mon_",
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("sahexFeBH0C4BdzlXu0WwQ#Value", "Currency MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Soc_",
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("cgvrXThItUiHkZCG_Z84UA#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Div_",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YHKD2MjD2kOkbdzpvHvwjA#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center; "
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pHqKrV2rqkGhs4Td3LIZWg#Value", "Paid")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("xeRNaiZY+EyB2QRUogcplg.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr;
}),
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("N9LgKP4ZukKEkAxBIOrqzw.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr;
}),
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "100"
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
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center; "
},
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_PaidAttr.nameAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_UnpaidAttr.nameAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr)]
}, $if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved), false, this, function () {
return [];
}, function () {
return [$if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.notPaid), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openUnpaidDetailPopup$Action(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_chat.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "109",
alias: "11"
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
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("A+X7CWzVRki34NDGPv1YyQ#ValueExpression.3159.1", "by") + " ") + model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_UnpaidAttr.nameAttr),
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_UnpaidAttr.nameAttr)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "113"
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
Position: ConectaProveedores_staticEntities_position.top,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
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
uuid: "114",
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
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dqTg2szAtkump6G7AYp2bA#ValueExpression.3159.1", "by") + " ") + model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_PaidAttr.nameAttr),
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).user_PaidAttr.nameAttr)]
}))];
})];
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut)]
}))];
}, function () {
return [$if((model.variables.l_ListForApprovalLevelDropdownVar.length > 1), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel auto-width",
visible: true,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_l_ProposalApprovalLevelId",
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qze3kQSFyUWMClayYUT6QA#Value", "Approval Level"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: true,
labels: function (elem) {
return elem.applicationRoleNameAttr;
},
list: model.variables.l_ListForApprovalLevelDropdownVar,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown_l_ProposalApprovalLevelIdOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.proposalApprovalLevelIdAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.l_ProposalApprovalLevelIdVar, function (value) {
model.variables.l_ProposalApprovalLevelIdVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_l_ProposalApprovalLevelId"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "120"
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
text: [$text(getTranslation("NIymWxidC0OCye70dY1Xmw#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("ClsUhbRgaUC8Pl3EnppyOA.Style"), function () {
return ((model.variables.getProposalApprovalLevelsAggr.countOut.gt(OS$BuiltinFunctions.integerToLongInteger(1))) ? (" margin-top-s") : (" "));
}, function () {
return model.variables.getProposalApprovalLevelsAggr.countOut;
}),
visible: true,
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr)
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "124",
alias: "13"
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
name: "ConectaProveedoresProposaDetailEditlProposalLinesB"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Cuenta",
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("EEssuv4kekSCI7Kfh06KqQ#Value", "Account"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Referencia",
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nDhTPqceMUy0ZyKqWlG9bA#Value", "Ref"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Nombre1",
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dGU6NTUQIEmWz+nn948zdA#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.N_doc_",
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DQCWx_94mEyHldg6MILNig#Value", "No. Doc."))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenML",
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("h79_uTUFHUC_vIOd8EeiQA#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.ML",
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Oo5+qPs5qUG4i8J8mOnW3A#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenMD",
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("eo4YfGWcZUqXHUrMSNYuTA#Value", "Amount MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Mon_",
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("TP16jdmGSkC3PcBB9dkAgQ#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Soc_",
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QF+i5ELn8k+CNqu8+weIwA#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Div_",
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PTkngwYwhUOkEo+Nr3z2jg#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
style: " setinvisible",
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("FBxdOQvWpkGSyRYJjFU65Q.style"), function () {
return ("text-align: center; " + ((((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.rejected))) ? (" ") : (" display:none;")));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
sortAttribute: "ProposalLineApprovalLevel.ApprovalStatusId",
style: " setinvisible",
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("OfBOEnfr60SF1FYkq4pMAQ#Value", "Approval")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr,
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr,
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("AHX6uHhTU0CKzr5L69JZaQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr, 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr;
}),
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr,
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("STuQROF+H0yDR26npp34bw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr, 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr;
}),
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr,
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr,
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "160"
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
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: model.getCachedValue(idService.getId("PPrXgV1s70SvLCs8VPbeKw.style"), function () {
return ("text-align: center; " + ((((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.inApproval) || (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.rejected))) ? (" ") : (" display:none;")));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr;
})
},
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr)]
}, $if(((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr) !== (ConectaProveedores_staticEntities_approvalStatus.notApproved)), false, this, function () {
return [$if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.rejected), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "164"
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
Position: ConectaProveedores_staticEntities_position.topRight,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
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
uuid: "165",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalLineApprovalLevelId: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr,
_i_ProposalLineApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
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
uuid: "168",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr)]
}), $if((ConectaProveedoresController$default.checkComissionesArrendamientosViewerRole$Action(callContext).hasRoleOut === false), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ig7RkWFDjE+PxsFUjWeE1g#Value.-1041456581.1", "Undo reject")
},
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.undoReject$Action(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "169"
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
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}))];
}, function () {
return [$if((model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.approved), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})];
}, function () {
return [];
}))];
}, callContext, idService, "3_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalLinesBVar,
TableName: idService.getId("ConectaProveedoresProposaDetailEditlProposalLinesB"),
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
uuid: "173",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalLinesBVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut)]
}))];
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.l_StartIndexVar,
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
uuid: "174",
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
uuid: "175",
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
uuid: "176"
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
uuid: "177"
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
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "text-align-left",
visible: true,
_idProps: {
service: idService,
uuid: "179"
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
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("kRtk9FZBY0+zpH5ohgk0hA#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((((ConectaProveedoresController$default.checkComissionesArrendamientosAdminRole$Action(callContext).hasRoleOut && (!((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.paid)))) && (!((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.beingPaid)))) && (!((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.errorAPI)))) && (!((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.canceled)))) && (!((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr === ConectaProveedores_staticEntities_proposalStatus.partiallyPaid)))), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideCancelPopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0odg1L_yLUKVysBhJwC3JQ#Value", "Cancel Proposal")))];
}, function () {
return [];
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "185"
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
uuid: "186"
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
alias: "19"
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
uuid: "188"
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
uuid: "189",
alias: "20"
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
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xyTj6QVGB0aGRJj4NTXg7A#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "191"
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
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "193"
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
i_ProposalLineId: model.getCachedValue(idService.getId("xIYOaxi6qUOdNkf4JAG4cg.i_ProposalLineId"), function () {
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
uuid: "194",
alias: "21"
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
alias: "22"
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
uuid: "196"
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
uuid: "197",
alias: "23"
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
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("z9Y6oEKYx0CJegOnBk0jow#Value", "Historic"))), createElement(OSWidgets$Container, {
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
uuid: "199"
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
uuid: "200"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "201"
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
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.l_SelectdLogDocumentNumberVar,
_idProps: {
service: idService,
uuid: "203"
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
i_ProposalId: model.variables.i_ProposalIdIn,
i_refresh: model.variables.l_RefeshDocumentSideBarVar,
i_ProposalLineId: model.variables.l_SelectdLogDocumentIdVar
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
uuid: "204",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "205"
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
uuid: "206"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NW6A7GLw30WNG_DviRPb8g#Value", "Amount"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card card-monto margin-top-xl",
visible: true,
_idProps: {
service: idService,
uuid: "207"
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
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("wV89PKoMcUG0UauY_4i07Q.Value"), function () {
return ((("(" + model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr) + ") ") + OS$BuiltinFunctions.formatCurrency(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ","));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "209"
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
uuid: "210"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("1Ty9juMXl0uqoGgb4UcWHQ#Value", "Proposal Lines"))],
_idProps: {
service: idService,
uuid: "211"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "212"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7",
value: (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr).toString(),
_idProps: {
service: idService,
uuid: "213"
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
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-top-l",
visible: (!(model.variables.getProposalByIdAggr.listOut.isEmpty)),
_idProps: {
service: idService,
uuid: "215"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
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
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lD7XamT+b0GgzstKSJqxaA#Value", "Approval"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-m font-semi-bold",
visible: true,
_idProps: {
service: idService,
uuid: "217"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalApprovalLevelsAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsVertical: true
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
uuid: "218",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getProposalApprovalLevelsAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "219"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Status: model.getCachedValue(idService.getId("43bUUdceeE+q51WedFzrsQ.Status"), function () {
return (((!(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasStartedAttr))) ? (ConectaProveedores_staticEntities_steps.next) : ((((model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasStartedAttr && model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasFinishedAttr)) ? (ConectaProveedores_staticEntities_steps.past) : (ConectaProveedores_staticEntities_steps.active))));
}, function () {
return model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasStartedAttr;
}, function () {
return model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasFinishedAttr;
}),
_statusInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr)
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
uuid: "220",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: (model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.levelNumberAttr).toString(),
_idProps: {
service: idService,
uuid: "221"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr)
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.approvalStatusIdAttr) !== (ConectaProveedores_staticEntities_approvalStatus.notApproved)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "222"
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
uuid: "223",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "text-align-left text-primary",
value: model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr,
_idProps: {
service: idService,
uuid: "224"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 24px;"
},
gridProperties: {
classes: "ThemeGrid_Width1"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "225"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.approvalStatusIdAttr === ConectaProveedores_staticEntities_approvalStatus.rejected), false, this, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "226"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "227"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "228"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("jSqS5jqmsUqPxhesyzIHVw.Style"), function () {
return ("text-align-left " + ((model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasStartedAttr) ? (" text-primary") : ("")));
}, function () {
return model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasStartedAttr;
}),
value: model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr,
_idProps: {
service: idService,
uuid: "229"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr),
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr)
}))];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.hasStartedAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.approvalStatusIdAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut.getCurrent(callContext.iterationContext).proposalApprovalLevelAttr.levelNumberAttr)]
})];
}, callContext, idService, "4")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut)]
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "230"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalLinesBVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.countOut), asPrimitiveValue(model.variables.l_ProposalApprovalLevelIdVar), asPrimitiveValue(model.variables.l_ListForApprovalLevelDropdownVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_DateTextFormattedVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(model.variables.getProposalStatusesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalStatusesAggr.listOut), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowCancelPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "231"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalId: model.variables.i_ProposalIdIn
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
cancel$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.cancelProposal$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "232",
alias: "28"
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
uuid: "233"
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
i_ProposalLineId: model.variables.l_ProposalLineIdVar
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
uuid: "234",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_ProposalLineIdVar), asPrimitiveValue(model.variables.l_ShowUnpaidDetailPopupVar), asPrimitiveValue(model.variables.l_ShowCancelPopupVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentIdVar), asPrimitiveValue(model.variables.l_RefeshDocumentSideBarVar), asPrimitiveValue(model.variables.l_SelectdLogDocumentNumberVar), asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalLinesBVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.listOut), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.countOut), asPrimitiveValue(model.variables.l_ProposalApprovalLevelIdVar), asPrimitiveValue(model.variables.l_ListForApprovalLevelDropdownVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_DateTextFormattedVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(model.variables.getProposalStatusesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalStatusesAggr.listOut), asPrimitiveValue(model.variables.getProposalApprovalLevelsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.proposalStatusIdAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalDetail",
functionKey: "e5763ffd-96bf-47c8-bcea-4a4f945f98fa",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_AdminCommissionsLeasing.ProposalDetail",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetail.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_y_Utils_Wb_TimelineStatus_mvc_view, ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_ProposalCanceledMotive_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_RejectedCommentTooltip_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, ConectaProveedores_b_CyA_AdminCommissionsLeasing_Wb_CancelProposalPopup_mvc_view, ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_Wb_UnpaidDetailPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
