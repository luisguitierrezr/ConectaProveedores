import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.mvc$controller.js";

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
animate: true,
style: "italic text-align-right",
visible: model.getCachedValue(idService.getId("XGjWT4DuB0Cr3Gmpx_Z6Vg.Visible"), function () {
return (((model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdByAttr) !== ((OS$BuiltinFunctions.nullIdentifier()).toString())) && !(model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdOnAttr.equals(OS$BuiltinFunctions.nullDate())));
}, function () {
return model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdByAttr;
}, function () {
return model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsRequisitionsDataDataAct.dataFetchStatusAttr)
}, $if((model.variables.getsRequisitionsDataDataAct.isDataFetchedAttr && (!(model.variables.getsRequisitionsDataDataAct.hasFetchErrorAttr))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("XvlbkoFO20aaxLZDK8veog.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("gBkJbEwaSEWcKcA6n_8ThA#ValueExpression.-931882833.1", "Created by") + " ") + model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdByAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdByAttr;
}, function () {
return model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsRequisitionsDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: ((model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.updatedByAttr) !== ("")),
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsRequisitionsDataDataAct.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("BB3RhfYPAUKhG46x52GgJg.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("I5Xjm8AaoEqzr9sbtJwVsQ#ValueExpression.1853933958.1", "Last updated by") + " ") + model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.updatedByAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.updatedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.updatedByAttr;
}, function () {
return model.variables.getsRequisitionsDataDataAct.o_RequisitionCreatedLogOut.updatedOnAttr;
}),
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getsRequisitionsDataDataAct.dataFetchStatusAttr)
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_RequisitionsCreatedOrUpdatedBy",
functionKey: "d6da78db-b6cb-4aef-8c3b-10df9528352a",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()
