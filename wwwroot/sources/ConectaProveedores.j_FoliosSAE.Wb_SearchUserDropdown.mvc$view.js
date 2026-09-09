import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression, Input as OSWidgets$Input, Link as OSWidgets$Link, Icon as OSWidgets$Icon, List as OSWidgets$List, Text as OSWidgets$Text } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Advanced_DropdownServerSide_mvc_view from "./OutSystemsUI.Advanced.DropdownServerSide.mvc$view.js";
import OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view from "./OutSystemsUI.Advanced.DropdownServerSideItem.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.mvc$controller.js";

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
style: model.getCachedValue(idService.getId("dhsiLx22p0iTwzMS+lzDUA.Style"), function () {
return ("os-boxlabel" + ((model.variables.i_IsValidIn) ? ("") : (" dropdown-invalid")));
}, function () {
return model.variables.i_IsValidIn;
}),
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsValidInDataFetchStatus)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("X+Yod0df8kKL64_1xIPgZw.Style"), function () {
return ((model.variables.i_IsMandatoryIn) ? ("mandatory") : (""));
}, function () {
return model.variables.i_IsMandatoryIn;
}),
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsMandatoryInDataFetchStatus)
}, $if(((model.variables.i_LabelTextIn) !== ("")), false, this, function () {
return [createElement(OSWidgets$Expression, {
value: model.variables.i_LabelTextIn,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_LabelTextInDataFetchStatus)
})];
}, function () {
return [$text(getTranslation("JaONdT7phUyMoJywlQVPzQ#Value", "User"))];
})), createElement(OutSystemsUI_Advanced_DropdownServerSide_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AllowMultipleSelection: false,
IsDisabled: model.variables.i_IsDisableIn,
_isDisabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsDisableInDataFetchStatus)
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
uuid: "3",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
balloonSearchInput: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "wcag-hide-text",
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("v62VRT3au0CDoxxs+fKnAQ#Value", "Type to Search"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
autoComplete: "off"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Search*/ 8,
mandatory: false,
maxLength: 50,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.input_UserSearchTextOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IyDkpO7J4USeek55PPLRsw#ValueExpression.-512840794.1", "Search..."),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_UserSearchTextVar, function (value) {
model.variables.l_UserSearchTextVar = value;
}),
_idProps: {
service: idService,
name: "Input_UserSearchText"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
balloonSearchInputIcon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearUser$Action(true, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
balloonContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getUsersAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ItemId: model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).userAttr.idAttr,
_itemIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersAggr.dataFetchStatusAttr),
IsSelected: (model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.idAttr === model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).userAttr.idAttr),
_isSelectedInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr, model.variables.getUsersAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (dropdownServerSideItemIdIn, itemOptionIdIn, dropdownServerSideIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.refresh$Action(OS$BuiltinFunctions.textToIdentifier(itemOptionIdIn), controller.callContext(eventHandlerContext));

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
placeholders: {
dropdownItemContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 12px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr + " - ") + model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr),
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUsersAggr.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUsersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).entraRoleAttr.roleNameAttr), asPrimitiveValue(model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).userAttr.emailAttr), asPrimitiveValue(model.variables.getUsersAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr)]
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.idAttr), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUsersAggr.dataFetchStatusAttr)]
}), $if(model.variables.getUsersAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "padding-s text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("eDwbuD3rS0yPzgvkse93PQ#Value", "No options to show...")))];
}, function () {
return [];
})];
}),
balloonFooter: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.loadMoreOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("u6tMSmHfpk+F+g9FgOLq5A#Value", "Load more")))];
}),
selectedValues: new Widget.PlaceholderContent(function () {
return [$if((!(model.variables.getUserByIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_Width10"
},
value: model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.clearUser$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon clear-dropdown",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if(model.variables.i_IsFilterIn, false, this, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("SjQMNYIEMEiYzGD5Eo9fJQ#Value", "All"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("xN3yj4xAjkSXZfKXzUmDKw#Value", "Select"))],
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_IsFilterIn), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.isEmpty), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getUserByIdAggr.listOut.getCurrent(callContext.iterationContext).userAttr.idAttr), asPrimitiveValue(model.variables._i_IsFilterInDataFetchStatus), asPrimitiveValue(model.variables.getUserByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUsersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUsersAggr.listOut), asPrimitiveValue(model.variables.l_UserSearchTextVar)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (!(model.variables.i_IsValidIn)),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsValidInDataFetchStatus)
}, createElement(OSWidgets$Text, {
style: "text-error font-size-xs",
text: [$text(getTranslation("DKy4+IBNkkOpZPF77jLW3A#Value", "This field is mandatory"))],
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SearchUserDropdown",
functionKey: "e06b50dc-17a7-4ef6-bdad-373413c7be62",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_SearchUserDropdown",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Advanced_DropdownServerSide_mvc_view, OutSystemsUI_Advanced_DropdownServerSideItem_mvc_view];
};


return ELEM;
};

export default componentFactory()
