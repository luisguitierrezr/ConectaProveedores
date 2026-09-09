namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] CfdFileWrapper (pqWXOF0EPkSkgJKsnhrRPA)
///  <code>ST_1e51b813a2c6a26cea1c6c8c17329da8Structure</code> that represent
/// s <code>CfdFileWrapper</code> <p>Description: CfdFileWrapper</p>
/// </summary>
// Name: CfdFileWrapper
public partial struct ST_1e51b813a2c6a26cea1c6c8c17329da8Structure : ITypedRecord<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure> {
internal static readonly GlobalObjectKey IdSociedad = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*bh3SyYXO5EKv9nJXWWn_Tw");
internal static readonly GlobalObjectKey IdCveProveedor = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*0jAob3QFzkqeTqy3z2ce0g");
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*cAPiRxAhukqTKHszK1Bm5g");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*eH6v6xQdRk6tNqdVvy4P4Q");
internal static readonly GlobalObjectKey IdArea = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*jj2GmxsYgE+3YaxjvQ+g+A");
internal static readonly GlobalObjectKey IdCapturaOrden = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*yGoADeI6TUOPd+k_nlicog");
internal static readonly GlobalObjectKey IdFactAnticipo = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*nA3v99WE3EqLz+94kT9HPw");
internal static readonly GlobalObjectKey IdFactServicio = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*RbWRSn2GHkyPoQwuMbuUig");
internal static readonly GlobalObjectKey IdOrdenCompra = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*1B3hZru+VEqkXSd3049OXw");
internal static readonly GlobalObjectKey IdEntradaMercancia = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*x2+r_tDRsEKanZpuXe_hlQ");
internal static readonly GlobalObjectKey IdDocType = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*NYszRU1d_EOqgfu5hiZrKw");
internal static readonly GlobalObjectKey IdFacturaEquipoCelular = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*u0RNOeUOHk+Ib1QUAOo5Cw");

public string ssSociedad;

public string ssCveProveedor;

public string ssFileName;

public string ssRegion;

public string ssArea;

public string ssCapturaOrden;

public string ssFactAnticipo;

public string ssFactServicio;

public string ssOrdenCompra;

public string ssEntradaMercancia;

public string ssDocType;

public string ssFacturaEquipoCelular;


public BitArray OptimizedAttributes;

public ST_1e51b813a2c6a26cea1c6c8c17329da8Structure() {
OptimizedAttributes = null;
ssSociedad = "";
ssCveProveedor = "";
ssFileName = "";
ssRegion = "";
ssArea = "";
ssCapturaOrden = "";
ssFactAnticipo = "";
ssFactServicio = "";
ssOrdenCompra = "";
ssEntradaMercancia = "";
ssDocType = "";
ssFacturaEquipoCelular = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSociedad = r.ReadText(index++, "CfdFileWrapper.Sociedad", "");
ssCveProveedor = r.ReadText(index++, "CfdFileWrapper.CveProveedor", "");
ssFileName = r.ReadText(index++, "CfdFileWrapper.FileName", "");
ssRegion = r.ReadText(index++, "CfdFileWrapper.Region", "");
ssArea = r.ReadText(index++, "CfdFileWrapper.Area", "");
ssCapturaOrden = r.ReadText(index++, "CfdFileWrapper.CapturaOrden", "");
ssFactAnticipo = r.ReadText(index++, "CfdFileWrapper.FactAnticipo", "");
ssFactServicio = r.ReadText(index++, "CfdFileWrapper.FactServicio", "");
ssOrdenCompra = r.ReadText(index++, "CfdFileWrapper.OrdenCompra", "");
ssEntradaMercancia = r.ReadText(index++, "CfdFileWrapper.EntradaMercancia", "");
ssDocType = r.ReadText(index++, "CfdFileWrapper.DocType", "");
ssFacturaEquipoCelular = r.ReadText(index++, "CfdFileWrapper.FacturaEquipoCelular", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_1e51b813a2c6a26cea1c6c8c17329da8Structure r) {
this = r;
}


public static bool operator == (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure a, ST_1e51b813a2c6a26cea1c6c8c17329da8Structure b) {
if (a.ssSociedad != b.ssSociedad) return false;
if (a.ssCveProveedor != b.ssCveProveedor) return false;
if (a.ssFileName != b.ssFileName) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssArea != b.ssArea) return false;
if (a.ssCapturaOrden != b.ssCapturaOrden) return false;
if (a.ssFactAnticipo != b.ssFactAnticipo) return false;
if (a.ssFactServicio != b.ssFactServicio) return false;
if (a.ssOrdenCompra != b.ssOrdenCompra) return false;
if (a.ssEntradaMercancia != b.ssEntradaMercancia) return false;
if (a.ssDocType != b.ssDocType) return false;
if (a.ssFacturaEquipoCelular != b.ssFacturaEquipoCelular) return false;
return true;
}

public static bool operator != (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure a, ST_1e51b813a2c6a26cea1c6c8c17329da8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure)) return false;
return (this == (ST_1e51b813a2c6a26cea1c6c8c17329da8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSociedad.GetHashCode()
 ^ ssCveProveedor.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssArea.GetHashCode()
 ^ ssCapturaOrden.GetHashCode()
 ^ ssFactAnticipo.GetHashCode()
 ^ ssFactServicio.GetHashCode()
 ^ ssOrdenCompra.GetHashCode()
 ^ ssEntradaMercancia.GetHashCode()
 ^ ssDocType.GetHashCode()
 ^ ssFacturaEquipoCelular.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1e51b813a2c6a26cea1c6c8c17329da8Structure Duplicate() {
ST_1e51b813a2c6a26cea1c6c8c17329da8Structure t;
t.ssSociedad = this.ssSociedad;
t.ssCveProveedor = this.ssCveProveedor;
t.ssFileName = this.ssFileName;
t.ssRegion = this.ssRegion;
t.ssArea = this.ssArea;
t.ssCapturaOrden = this.ssCapturaOrden;
t.ssFactAnticipo = this.ssFactAnticipo;
t.ssFactServicio = this.ssFactServicio;
t.ssOrdenCompra = this.ssOrdenCompra;
t.ssEntradaMercancia = this.ssEntradaMercancia;
t.ssDocType = this.ssDocType;
t.ssFacturaEquipoCelular = this.ssFacturaEquipoCelular;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "sociedad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sociedad")) variable.Value = ssSociedad; else variable.Optimized = true;
} else if (head == "cveproveedor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CveProveedor")) variable.Value = ssCveProveedor; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "area") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Area")) variable.Value = ssArea; else variable.Optimized = true;
} else if (head == "capturaorden") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CapturaOrden")) variable.Value = ssCapturaOrden; else variable.Optimized = true;
} else if (head == "factanticipo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FactAnticipo")) variable.Value = ssFactAnticipo; else variable.Optimized = true;
} else if (head == "factservicio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FactServicio")) variable.Value = ssFactServicio; else variable.Optimized = true;
} else if (head == "ordencompra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdenCompra")) variable.Value = ssOrdenCompra; else variable.Optimized = true;
} else if (head == "entradamercancia") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntradaMercancia")) variable.Value = ssEntradaMercancia; else variable.Optimized = true;
} else if (head == "doctype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocType")) variable.Value = ssDocType; else variable.Optimized = true;
} else if (head == "facturaequipocelular") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FacturaEquipoCelular")) variable.Value = ssFacturaEquipoCelular; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSociedad) {
return ssSociedad;
}
if (key == IdCveProveedor) {
return ssCveProveedor;
}
if (key == IdFileName) {
return ssFileName;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdArea) {
return ssArea;
}
if (key == IdCapturaOrden) {
return ssCapturaOrden;
}
if (key == IdFactAnticipo) {
return ssFactAnticipo;
}
if (key == IdFactServicio) {
return ssFactServicio;
}
if (key == IdOrdenCompra) {
return ssOrdenCompra;
}
if (key == IdEntradaMercancia) {
return ssEntradaMercancia;
}
if (key == IdDocType) {
return ssDocType;
}
if (key == IdFacturaEquipoCelular) {
return ssFacturaEquipoCelular;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSociedad.Key.AsGuid) {
return ssSociedad;
}
if (attributeKey == IdCveProveedor.Key.AsGuid) {
return ssCveProveedor;
}
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdArea.Key.AsGuid) {
return ssArea;
}
if (attributeKey == IdCapturaOrden.Key.AsGuid) {
return ssCapturaOrden;
}
if (attributeKey == IdFactAnticipo.Key.AsGuid) {
return ssFactAnticipo;
}
if (attributeKey == IdFactServicio.Key.AsGuid) {
return ssFactServicio;
}
if (attributeKey == IdOrdenCompra.Key.AsGuid) {
return ssOrdenCompra;
}
if (attributeKey == IdEntradaMercancia.Key.AsGuid) {
return ssEntradaMercancia;
}
if (attributeKey == IdDocType.Key.AsGuid) {
return ssDocType;
}
if (attributeKey == IdFacturaEquipoCelular.Key.AsGuid) {
return ssFacturaEquipoCelular;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSociedad = (string) other.AttributeGet(IdSociedad);
ssCveProveedor = (string) other.AttributeGet(IdCveProveedor);
ssFileName = (string) other.AttributeGet(IdFileName);
ssRegion = (string) other.AttributeGet(IdRegion);
ssArea = (string) other.AttributeGet(IdArea);
ssCapturaOrden = (string) other.AttributeGet(IdCapturaOrden);
ssFactAnticipo = (string) other.AttributeGet(IdFactAnticipo);
ssFactServicio = (string) other.AttributeGet(IdFactServicio);
ssOrdenCompra = (string) other.AttributeGet(IdOrdenCompra);
ssEntradaMercancia = (string) other.AttributeGet(IdEntradaMercancia);
ssDocType = (string) other.AttributeGet(IdDocType);
ssFacturaEquipoCelular = (string) other.AttributeGet(IdFacturaEquipoCelular);
}
} // ST_1e51b813a2c6a26cea1c6c8c17329da8Structure
/// <summary>
/// RecordList type <code>CfdFileWrapperList</code> that represents a record list of
///  <code>CfdFileWrapper</code>
/// </summary>
public partial class RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 : GenericRecordList<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure>, IEnumerable, IEnumerator {

protected override ST_1e51b813a2c6a26cea1c6c8c17329da8Structure GetElementDefaultValue() {
return new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure();
}

public T[] ToArray<T>(Func<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 recordList, Func<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7028adf0a3437a2ff7fd9fb2c1cc52d0(ST_1e51b813a2c6a26cea1c6c8c17329da8Structure[] array) {
  RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 result = new RL_7028adf0a3437a2ff7fd9fb2c1cc52d0();
result.InnerFromArray(array);
    return result;
}

public static RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 ToList<T>(T[] array, Func <T, ST_1e51b813a2c6a26cea1c6c8c17329da8Structure> converter) {
  RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 result = new RL_7028adf0a3437a2ff7fd9fb2c1cc52d0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 FromRestList<T>(RestList<T> restList, Func <T, ST_1e51b813a2c6a26cea1c6c8c17329da8Structure> converter) {
  RL_7028adf0a3437a2ff7fd9fb2c1cc52d0 result = new RL_7028adf0a3437a2ff7fd9fb2c1cc52d0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7028adf0a3437a2ff7fd9fb2c1cc52d0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1e51b813a2c6a26cea1c6c8c17329da8Structure> NewList() {
return new RL_7028adf0a3437a2ff7fd9fb2c1cc52d0();
}


} // RL_7028adf0a3437a2ff7fd9fb2c1cc52d0
}

