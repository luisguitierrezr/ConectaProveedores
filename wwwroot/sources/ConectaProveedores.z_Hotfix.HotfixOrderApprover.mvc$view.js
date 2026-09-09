import { withBaseWebScreen, Widget, asPrimitiveValue, ifWidget as $if, useTracing, getTranslation } from "@outsystems/runtime-view-js";
import Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvc_view from "./Telcel_Theme.Theme_Layouts.Layout_Top_Menu.mvc$view.js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Button as OSWidgets$Button, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.mvc$view.js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import Debounce_DebounceFlow_Debounce_mvc_view from "./Debounce.DebounceFlow.Debounce.mvc$view.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ModelFactory from "./ConectaProveedores.z_Hotfix.HotfixOrderApprover.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.z_Hotfix.HotfixOrderApprover.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvc_view, {
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: Widget.PlaceholderContent.Empty,
breadcrumbs: Widget.PlaceholderContent.Empty,
title: Widget.PlaceholderContent.Empty,
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Usuario original"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsValid: true,
i_IsDisable: false,
i_UserId: model.variables.userOriginalVar,
i_IsMandatory: true,
i_IsFilter: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (userIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_DropdownSelectUserOriginal$Action(userIdIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "5",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m os-boxlabel custom-container",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Usuario sustituto"), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsDisable: false,
i_IsMandatory: true,
i_IsValid: true,
i_UserId: model.variables.userSubstituteVar,
i_IsFilter: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (userIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DropdownSelectUserSubstitute$Action(userIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "9",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Button, {
confirmationMessage: "Estás seguro?",
enabled: model.getCachedValue(idService.getId("uaUOZJblHk2sKDL1vDIFjw.Enabled"), function () {
return (((((model.variables.userOriginalVar) !== (OS$BuiltinFunctions.nullTextIdentifier())) && ((model.variables.userSubstituteVar) !== (OS$BuiltinFunctions.nullTextIdentifier()))) && model.variables.getOrderApprovalLevelsByAssignedToAggr.isDataFetchedAttr) && (!(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.isEmpty)));
}, function () {
return model.variables.userOriginalVar;
}, function () {
return model.variables.userSubstituteVar;
}, function () {
return model.variables.getOrderApprovalLevelsByAssignedToAggr.isDataFetchedAttr;
}, function () {
return model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.isEmpty;
}),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.replaceAllOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
}, "Reemplazar todos")), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.getCachedValue(idService.getId("Input_TextVar.Enabled"), function () {
return ((model.variables.userOriginalVar) !== (OS$BuiltinFunctions.nullTextIdentifier()));
}, function () {
return model.variables.userOriginalVar;
}),
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Search*/ 8,
mandatory: false,
maxLength: 50,
prompt: "Número de pedido",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.orderNumberFilterVar, function (value) {
model.variables.orderNumberFilterVar = value;
}),
_idProps: {
service: idService,
name: "Input_TextVar"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(Debounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_TextVar")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.debounceOnDebounce$Action(controller.callContext(eventHandlerContext));
});
;
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
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: "Seleccionar estatus",
enabled: model.getCachedValue(idService.getId("Dropdown1.Enabled"), function () {
return ((model.variables.userOriginalVar) !== (OS$BuiltinFunctions.nullTextIdentifier()));
}, function () {
return model.variables.userOriginalVar;
}),
labels: function (elem) {
return elem.orderStatusAttr.labelESAttr;
},
list: model.variables.getOrderStatusesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.dropdown1OnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.orderStatusAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.orderStatusIdVar, function (value) {
model.variables.orderStatusIdVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown1"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderStatusesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
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
uuid: "18",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return ["Pedidos"];
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
uuid: "19",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("62_+L5juTUq0gxXyPo2feQ.Visible"), function () {
return ((model.variables.userOriginalVar) !== (OS$BuiltinFunctions.nullTextIdentifier()));
}, function () {
return model.variables.userOriginalVar;
}),
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderApprovalLevelsByAssignedToAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "table-empty",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, "No hay elementos que mostrar...")];
}, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "22",
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
source: model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Número de Pedido"), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "OrderApprovalLevel.LevelNumber",
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Nivel de aprobación"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "EntraRole.RoleName",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Puesto"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderApprovalLevel.AssignedTo",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "Asignado a"), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.levelNumberAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.levelNumberAttr).toString(),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.userSubstituteVar)]
}, createElement(OSWidgets$Button, {
confirmationMessage: "Estás seguro?",
enabled: model.getCachedValue(idService.getId("D3eFHhS6ykCq4jh3FTSZDA.Enabled"), function () {
return ((model.variables.userSubstituteVar) !== (OS$BuiltinFunctions.nullTextIdentifier()));
}, function () {
return model.variables.userSubstituteVar;
}),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.replaceSingleOnClick$Action(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, "Reemplazar"))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.userSubstituteVar), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.userSubstituteVar), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut)]
}), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getOrderApprovalLevelsByAssignedToAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr),
MaxRecords: model.variables.maxRecordsVar
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
uuid: "40",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "caret-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "caret-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "42"
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
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.userSubstituteVar), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.countOut), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.userOriginalVar)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.userSubstituteVar), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.countOut), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.userOriginalVar)]
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.getOrderStatusesAggr.listOut), asPrimitiveValue(model.variables.orderStatusIdVar), asPrimitiveValue(model.variables.orderNumberFilterVar), asPrimitiveValue(model.variables.getOrderStatusesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.countOut), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.listOut), asPrimitiveValue(model.variables.getOrderApprovalLevelsByAssignedToAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.userSubstituteVar), asPrimitiveValue(model.variables.userOriginalVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "HotfixOrderApprover",
functionKey: "8f2f9ed6-67c6-4eac-8cd7-ea9ae20a710f",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "z_Hotfix.HotfixOrderApprover",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function () {
return getTranslation("1p4vj8ZnrE6M1+qa4gpxDw#Title", "HotfixOrderApprover");
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [Telcel_Theme_Theme_Layouts_Layout_Top_Menu_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, Debounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view];
};


return ELEM;
};

export default componentFactory()
