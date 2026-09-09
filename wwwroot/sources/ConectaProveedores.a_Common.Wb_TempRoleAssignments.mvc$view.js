import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Button as OSWidgets$Button, Image as OSWidgets$Image, List as OSWidgets$List, Expression as OSWidgets$Expression, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { EN_20bdea9cf8f17569719f414a83b584b6EntityRecord } from "./SecurityAuth.model.js";
import { Navigation as OS$Navigation, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import OutSystemsUI_Content_ListItemContent_mvc_view from "./OutSystemsUI.Content.ListItemContent.mvc$view.js";
import { SE_roleStatus as ConectaProveedores_staticEntities_roleStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvc_view from "./ConectaProveedores.a_Common.Wb_AssignTempRolePopup.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Common.Wb_TempRoleAssignments.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Common.Wb_TempRoleAssignments.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "1"
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
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("08oDc4W90EaeatYbk0F0Bg#Value", "Substitutions"))],
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
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
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideShowAssignTempRolePopup$Action(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), controller.callContext(eventHandlerContext));

;
},
style: "btn btn-plusbutton",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.whiteplus.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
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
uuid: "8",
alias: "1"
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
uuid: "9",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("4N1nanJ9uUK7m2zwaVanlQ#Value", "Created"))],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "11",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("19pTBlXzikSGaa_LVKz43g#Value", "Assigned"))],
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
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
uuid: "13",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getUserApplicationRoleTempsByAssignedByAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aLP+dY0LzUSOvxJprCViaw#Value", "No substitutions history...")))];
}, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).roleStatusAttr.labelAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr)]
}, createElement(OutSystemsUI_Content_ListItemContent_mvc_view, {
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
uuid: "17",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
left: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("eIRsjM7L5kaywvTnao3SPg.Style"), function () {
return ("status role-status " + (((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.toBeActive)) ? ("rolestatus-tobeactive") : ((((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.active)) ? ("rolestatus-active") : ((((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.revoked)) ? ("rolestatus-revoked") : ("rolestatus-expired")))))));
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
value: model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).roleStatusAttr.labelAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr)
}))];
}),
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "margin-left-s font-s font-size-s text-neutral-8",
value: model.getCachedValue(idService.getId("ZgXvApOX7UGlj+BbJ2ncxA.Value"), function () {
return (((("(" + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr, "dd/MM/yyyy")) + " - ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr, "dd/MM/yyyy")) + ")");
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr;
}),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr)
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
style: "font-semi-bold italic font-size-xs",
value: model.getCachedValue(idService.getId("9103YJNkIE6zii9wKn5Ksw.Value"), function () {
return ((((((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) ? (((((((((" " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.-885218359.1", "Assigned by")) + " ") + (((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr === OS$BuiltinFunctions.getUserId())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.3480.1", "me")) : (model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr))) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.3551.1", "on")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr, "dd/MM/yyyy")) + ".")) : ("")) + ((!(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (((((" " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.1853934350.1", "Last updated on")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr, "dd/MM/yyyy HH:mm")) + ".")) : (""))) + ((((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) ? (((((((((" " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.1282945337.1", "Revoked by")) + " ") + (((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr === OS$BuiltinFunctions.getUserId())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.3480.2", "me")) : (model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr))) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rPSxT1fux02NBMLBPOVxDw#ValueExpression.3551.2", "on")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr, "dd/MM/yyyy")) + ".")) : ("")));
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr;
}),
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr)
})];
}),
right: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.revoked) || (model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.expired)), false, this, function () {
return [];
}, function () {
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
uuid: "25",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideShowAssignTempRolePopup$Action(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "Link_EditTempAssignment2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "pencil",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if((((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr) !== (ConectaProveedores_staticEntities_roleStatus.revoked)) && ((model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr) !== (ConectaProveedores_staticEntities_roleStatus.expired))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideConfirmPopup$Action(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "Link_CancelTempAssignment2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "ban",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr)]
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).roleStatusAttr.labelAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.l_StartIndexVar,
TotalCount: model.variables.getUserApplicationRoleTempsByAssignedByAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr),
MaxRecords: model.variables.l_MaxRecordsVar
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
uuid: "31",
alias: "7"
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
uuid: "32"
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
uuid: "33"
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
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_MaxRecordsVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.countOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.isDataFetchedAttr)]
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
uuid: "35",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getUserApplicationRoleTempsByUserIdAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nbTLtVFZPkiIirIyqgbDag#Value", "No substitutions history...")))];
}, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).roleStatusAttr.labelAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr)]
}, createElement(OutSystemsUI_Content_ListItemContent_mvc_view, {
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
uuid: "39",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
left: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("1ONCM0phqUamDN0okLCVhQ.Style"), function () {
return ("status " + (((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.toBeActive)) ? ("rolestatus-tobeactive") : ((((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.active)) ? ("rolestatus-active") : ((((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr === ConectaProveedores_staticEntities_roleStatus.revoked)) ? ("rolestatus-revoked") : ("rolestatus-expired")))))));
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
value: model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).roleStatusAttr.labelAttr,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)
}))];
}),
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "margin-left-s font-s font-size-s text-neutral-8",
value: model.getCachedValue(idService.getId("nHJpdkre7UilLvVoFw7_kw.Value"), function () {
return (((("(" + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr, "dd/MM/yyyy")) + " - ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr, "dd/MM/yyyy")) + ")");
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr;
}),
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
style: "font-semi-bold italic font-size-xs",
value: model.getCachedValue(idService.getId("0dGENVuRsUWkRf_pHd3KPQ.Value"), function () {
return ((((((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) ? (((((((((" " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.-931882833.1", "Created by")) + " ") + (((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr === OS$BuiltinFunctions.getUserId())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.89087.1", "You")) : (model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr))) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.3551.1", "on")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr, "dd/MM/yyyy")) + ".")) : ("")) + ((!(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr.equals(OS$BuiltinFunctions.nullDate()))) ? (((((" " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.1853934350.1", "Last updated on")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr, "dd/MM/yyyy HH:mm")) + ".")) : (""))) + ((((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()))) ? (((((((((" " + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.1282945337.1", "Revoked by")) + " ") + (((model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr === OS$BuiltinFunctions.getUserId())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.89087.2", "You")) : (model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr))) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0FcNTc5FEkShFwKclClG1A#ValueExpression.3551.2", "on")) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr, "dd/MM/yyyy")) + ".")) : ("")));
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr;
}, function () {
return model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr;
}),
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)
})];
}),
right: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_RevokedAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).user_AssignedByAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).roleStatusAttr.labelAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.revokedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.lastUpdatedOnAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedDateAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.assignedByAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateToAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.dateFromAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut.getCurrent(callContext.iterationContext).userApplicationRoleTempAttr.roleStatusIdAttr)]
}))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: model.variables.l_MaxRecordsAssignedVar,
StartIndex: model.variables.l_StartIndexAssignedVar,
TotalCount: model.variables.getUserApplicationRoleTempsByUserIdAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigateAssigned$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "46",
alias: "10"
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
uuid: "47"
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
uuid: "48"
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
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_StartIndexAssignedVar), asPrimitiveValue(model.variables.l_MaxRecordsAssignedVar), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.countOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.isDataFetchedAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_StartIndexAssignedVar), asPrimitiveValue(model.variables.l_MaxRecordsAssignedVar), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.countOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.listOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_MaxRecordsVar), asPrimitiveValue(model.variables.l_StartIndexVar), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByUserIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.countOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.listOut), asPrimitiveValue(model.variables.getUserApplicationRoleTempsByAssignedByAggr.isDataFetchedAttr)]
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowAssignTempRolePopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
l_UserApplicationRoleTemp: model.variables.l_UserApplicationRoleTempVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideShowAssignTempRolePopup$Action(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), controller.callContext(eventHandlerContext));

;
},
save$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_AssignTempRolePopupSave$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "51",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_ShowConfirmPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Z4AAB08dmUCk5YieBkJuQA#Value.-565738638.1", "Are you sure you want to cancel this substitution?"),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pASwm6GcU0qFaXdv2HnpaQ#Value.-234536253.1", "Cancel substitution")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideConfirmPopup$Action(new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), controller.callContext(eventHandlerContext));

;
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_ConfirmPopupConfirm$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "53",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_TempRoleAssignments",
functionKey: "4a543e1b-744a-4cee-a52e-12721c3453a5",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Common.Wb_TempRoleAssignments",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.a_Common.Wb_TempRoleAssignments.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, OutSystemsUI_Content_ListItemContent_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view, ConectaProveedores_a_Common_Wb_AssignTempRolePopup_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
