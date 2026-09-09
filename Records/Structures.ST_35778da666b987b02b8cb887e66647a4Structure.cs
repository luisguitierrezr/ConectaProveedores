namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZTC_GENERA_POLIZA_GRALResp (K7jm_KJHuUWP68UJ+y_pRg)
///  <code>ST_35778da666b987b02b8cb887e66647a4Structure</code> that represent
/// s <code>ZTC_GENERA_POLIZA_GRALResp</code> <p>Description: ZTC_GENERA_POLIZA_GRALResp</p>
/// </summary>
// Name: ZTC_GENERA_POLIZA_GRALResp
public partial struct ST_35778da666b987b02b8cb887e66647a4Structure : ITypedRecord<ST_35778da666b987b02b8cb887e66647a4Structure> {
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*j8_2hQes7U+4kip9WfhXrg");
internal static readonly GlobalObjectKey IdTI_POS_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*jFxJFxTAkkm48GjZxQEwOQ");
internal static readonly GlobalObjectKey IdTO_RESULTADO_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ADJCOKUhUES5ubUwROSshA");

public string ssPO_RESULTADO;

public RL_480c1f8575ebe73e18b76b318e3cf1a3 ssTI_POS_Out;

public RL_48c08abdc43583e242f48c4245aed919 ssTO_RESULTADO_Out;


public BitArray OptimizedAttributes;

public ST_35778da666b987b02b8cb887e66647a4Structure() {
OptimizedAttributes = null;
ssPO_RESULTADO = "";
ssTI_POS_Out = new RL_480c1f8575ebe73e18b76b318e3cf1a3();
ssTO_RESULTADO_Out = new RL_48c08abdc43583e242f48c4245aed919();
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
ssPO_RESULTADO = r.ReadText(index++, "ZTC_GENERA_POLIZA_GRALResp.PO_RESULTADO", "");
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
public void ReadIM(ST_35778da666b987b02b8cb887e66647a4Structure r) {
this = r;
}


public static bool operator == (ST_35778da666b987b02b8cb887e66647a4Structure a, ST_35778da666b987b02b8cb887e66647a4Structure b) {
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
if (a.ssTI_POS_Out != b.ssTI_POS_Out) return false;
if (a.ssTO_RESULTADO_Out != b.ssTO_RESULTADO_Out) return false;
return true;
}

public static bool operator != (ST_35778da666b987b02b8cb887e66647a4Structure a, ST_35778da666b987b02b8cb887e66647a4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_35778da666b987b02b8cb887e66647a4Structure)) return false;
return (this == (ST_35778da666b987b02b8cb887e66647a4Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPO_RESULTADO.GetHashCode()
 ^ ssTI_POS_Out.GetHashCode()
 ^ ssTO_RESULTADO_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssTI_POS_Out.RecursiveReset();
ssTO_RESULTADO_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssTI_POS_Out.InternalRecursiveSave();
ssTO_RESULTADO_Out.InternalRecursiveSave();
}


public ST_35778da666b987b02b8cb887e66647a4Structure Duplicate() {
ST_35778da666b987b02b8cb887e66647a4Structure t;
t.ssPO_RESULTADO = this.ssPO_RESULTADO;
t.ssTI_POS_Out = (RL_480c1f8575ebe73e18b76b318e3cf1a3)this.ssTI_POS_Out.Duplicate();
t.ssTO_RESULTADO_Out = (RL_48c08abdc43583e242f48c4245aed919)this.ssTO_RESULTADO_Out.Duplicate();
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
if (head == "po_resultado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESULTADO")) variable.Value = ssPO_RESULTADO; else variable.Optimized = true;
} else if (head == "ti_pos_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_POS_Out")) variable.Value = ssTI_POS_Out; else variable.Optimized = true;
variable.SetFieldName("ti_pos_out");
} else if (head == "to_resultado_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TO_RESULTADO_Out")) variable.Value = ssTO_RESULTADO_Out; else variable.Optimized = true;
variable.SetFieldName("to_resultado_out");
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
if (key == IdPO_RESULTADO) {
return ssPO_RESULTADO;
}
if (key == IdTI_POS_Out) {
return ssTI_POS_Out;
}
if (key == IdTO_RESULTADO_Out) {
return ssTO_RESULTADO_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
if (attributeKey == IdTI_POS_Out.Key.AsGuid) {
return ssTI_POS_Out;
}
if (attributeKey == IdTO_RESULTADO_Out.Key.AsGuid) {
return ssTO_RESULTADO_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
ssTI_POS_Out = new RL_480c1f8575ebe73e18b76b318e3cf1a3();
ssTI_POS_Out.FillFromOther((IOSList) other.AttributeGet(IdTI_POS_Out));
ssTO_RESULTADO_Out = new RL_48c08abdc43583e242f48c4245aed919();
ssTO_RESULTADO_Out.FillFromOther((IOSList) other.AttributeGet(IdTO_RESULTADO_Out));
}
} // ST_35778da666b987b02b8cb887e66647a4Structure
/// <summary>
/// RecordList type <code>ZTC_GENERA_POLIZA_GRALRespList</code> that represents a record list of
///  <code>ZTC_GENERA_POLIZA_GRALResp</code>
/// </summary>
public partial class RL_e7dcfb644fde5f18fda8e8322f3e3628 : GenericRecordList<ST_35778da666b987b02b8cb887e66647a4Structure>, IEnumerable, IEnumerator {

protected override ST_35778da666b987b02b8cb887e66647a4Structure GetElementDefaultValue() {
return new ST_35778da666b987b02b8cb887e66647a4Structure();
}

public T[] ToArray<T>(Func<ST_35778da666b987b02b8cb887e66647a4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e7dcfb644fde5f18fda8e8322f3e3628 recordList, Func<ST_35778da666b987b02b8cb887e66647a4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e7dcfb644fde5f18fda8e8322f3e3628(ST_35778da666b987b02b8cb887e66647a4Structure[] array) {
  RL_e7dcfb644fde5f18fda8e8322f3e3628 result = new RL_e7dcfb644fde5f18fda8e8322f3e3628();
result.InnerFromArray(array);
    return result;
}

public static RL_e7dcfb644fde5f18fda8e8322f3e3628 ToList<T>(T[] array, Func <T, ST_35778da666b987b02b8cb887e66647a4Structure> converter) {
  RL_e7dcfb644fde5f18fda8e8322f3e3628 result = new RL_e7dcfb644fde5f18fda8e8322f3e3628();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e7dcfb644fde5f18fda8e8322f3e3628 FromRestList<T>(RestList<T> restList, Func <T, ST_35778da666b987b02b8cb887e66647a4Structure> converter) {
  RL_e7dcfb644fde5f18fda8e8322f3e3628 result = new RL_e7dcfb644fde5f18fda8e8322f3e3628();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e7dcfb644fde5f18fda8e8322f3e3628() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_35778da666b987b02b8cb887e66647a4Structure> NewList() {
return new RL_e7dcfb644fde5f18fda8e8322f3e3628();
}


} // RL_e7dcfb644fde5f18fda8e8322f3e3628
}

