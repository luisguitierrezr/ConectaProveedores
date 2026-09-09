namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_CONTA_FACTURASResp (AMfEfEF410u9l_ofrZe42Q)
///  <code>ST_926df962559a6c34055113c885aa4885Structure</code> that represent
/// s <code>ZMXFFIMF_CONTA_FACTURASResp</code> <p>Description: ZMXFFIMF_CONTA_FACTURASResp</p>
/// </summary>
// Name: ZMXFFIMF_CONTA_FACTURASResp
public partial struct ST_926df962559a6c34055113c885aa4885Structure : ITypedRecord<ST_926df962559a6c34055113c885aa4885Structure> {
internal static readonly GlobalObjectKey IdPE_RESPUESTA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*mDOcqlZrYUSzbfHDRRolxQ");
internal static readonly GlobalObjectKey IdTI_ITEM_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*G3F5Jv07T0+xM2AC5ja7Ew");
internal static readonly GlobalObjectKey IdTI_WXD_Out = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*uRuyftn82ky45m7XiSvAwQ");

public string ssPE_RESPUESTA;

public RL_e1d78e9541666a9f848546c9e0e8c78e ssTI_ITEM_Out;

public RL_ede476728417dba9bcd8aba956158c2a ssTI_WXD_Out;


public BitArray OptimizedAttributes;

public ST_926df962559a6c34055113c885aa4885Structure() {
OptimizedAttributes = null;
ssPE_RESPUESTA = "";
ssTI_ITEM_Out = new RL_e1d78e9541666a9f848546c9e0e8c78e();
ssTI_WXD_Out = new RL_ede476728417dba9bcd8aba956158c2a();
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
ssPE_RESPUESTA = r.ReadText(index++, "ZMXFFIMF_CONTA_FACTURASResp.PE_RESPUESTA", "");
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
public void ReadIM(ST_926df962559a6c34055113c885aa4885Structure r) {
this = r;
}


public static bool operator == (ST_926df962559a6c34055113c885aa4885Structure a, ST_926df962559a6c34055113c885aa4885Structure b) {
if (a.ssPE_RESPUESTA != b.ssPE_RESPUESTA) return false;
if (a.ssTI_ITEM_Out != b.ssTI_ITEM_Out) return false;
if (a.ssTI_WXD_Out != b.ssTI_WXD_Out) return false;
return true;
}

public static bool operator != (ST_926df962559a6c34055113c885aa4885Structure a, ST_926df962559a6c34055113c885aa4885Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_926df962559a6c34055113c885aa4885Structure)) return false;
return (this == (ST_926df962559a6c34055113c885aa4885Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPE_RESPUESTA.GetHashCode()
 ^ ssTI_ITEM_Out.GetHashCode()
 ^ ssTI_WXD_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssTI_ITEM_Out.RecursiveReset();
ssTI_WXD_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssTI_ITEM_Out.InternalRecursiveSave();
ssTI_WXD_Out.InternalRecursiveSave();
}


public ST_926df962559a6c34055113c885aa4885Structure Duplicate() {
ST_926df962559a6c34055113c885aa4885Structure t;
t.ssPE_RESPUESTA = this.ssPE_RESPUESTA;
t.ssTI_ITEM_Out = (RL_e1d78e9541666a9f848546c9e0e8c78e)this.ssTI_ITEM_Out.Duplicate();
t.ssTI_WXD_Out = (RL_ede476728417dba9bcd8aba956158c2a)this.ssTI_WXD_Out.Duplicate();
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
if (head == "pe_respuesta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PE_RESPUESTA")) variable.Value = ssPE_RESPUESTA; else variable.Optimized = true;
} else if (head == "ti_item_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_ITEM_Out")) variable.Value = ssTI_ITEM_Out; else variable.Optimized = true;
variable.SetFieldName("ti_item_out");
} else if (head == "ti_wxd_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_WXD_Out")) variable.Value = ssTI_WXD_Out; else variable.Optimized = true;
variable.SetFieldName("ti_wxd_out");
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
if (key == IdPE_RESPUESTA) {
return ssPE_RESPUESTA;
}
if (key == IdTI_ITEM_Out) {
return ssTI_ITEM_Out;
}
if (key == IdTI_WXD_Out) {
return ssTI_WXD_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPE_RESPUESTA.Key.AsGuid) {
return ssPE_RESPUESTA;
}
if (attributeKey == IdTI_ITEM_Out.Key.AsGuid) {
return ssTI_ITEM_Out;
}
if (attributeKey == IdTI_WXD_Out.Key.AsGuid) {
return ssTI_WXD_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPE_RESPUESTA = (string) other.AttributeGet(IdPE_RESPUESTA);
ssTI_ITEM_Out = new RL_e1d78e9541666a9f848546c9e0e8c78e();
ssTI_ITEM_Out.FillFromOther((IOSList) other.AttributeGet(IdTI_ITEM_Out));
ssTI_WXD_Out = new RL_ede476728417dba9bcd8aba956158c2a();
ssTI_WXD_Out.FillFromOther((IOSList) other.AttributeGet(IdTI_WXD_Out));
}
} // ST_926df962559a6c34055113c885aa4885Structure
/// <summary>
/// RecordList type <code>ZMXFFIMF_CONTA_FACTURASRespList</code> that represents a record list of
///  <code>ZMXFFIMF_CONTA_FACTURASResp</code>
/// </summary>
public partial class RL_525a0d4ae1ff27614b8a762648fd12f8 : GenericRecordList<ST_926df962559a6c34055113c885aa4885Structure>, IEnumerable, IEnumerator {

protected override ST_926df962559a6c34055113c885aa4885Structure GetElementDefaultValue() {
return new ST_926df962559a6c34055113c885aa4885Structure();
}

public T[] ToArray<T>(Func<ST_926df962559a6c34055113c885aa4885Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_525a0d4ae1ff27614b8a762648fd12f8 recordList, Func<ST_926df962559a6c34055113c885aa4885Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_525a0d4ae1ff27614b8a762648fd12f8(ST_926df962559a6c34055113c885aa4885Structure[] array) {
  RL_525a0d4ae1ff27614b8a762648fd12f8 result = new RL_525a0d4ae1ff27614b8a762648fd12f8();
result.InnerFromArray(array);
    return result;
}

public static RL_525a0d4ae1ff27614b8a762648fd12f8 ToList<T>(T[] array, Func <T, ST_926df962559a6c34055113c885aa4885Structure> converter) {
  RL_525a0d4ae1ff27614b8a762648fd12f8 result = new RL_525a0d4ae1ff27614b8a762648fd12f8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_525a0d4ae1ff27614b8a762648fd12f8 FromRestList<T>(RestList<T> restList, Func <T, ST_926df962559a6c34055113c885aa4885Structure> converter) {
  RL_525a0d4ae1ff27614b8a762648fd12f8 result = new RL_525a0d4ae1ff27614b8a762648fd12f8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_525a0d4ae1ff27614b8a762648fd12f8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_926df962559a6c34055113c885aa4885Structure> NewList() {
return new RL_525a0d4ae1ff27614b8a762648fd12f8();
}


} // RL_525a0d4ae1ff27614b8a762648fd12f8
}

