namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXFFIMF_0250_FI_CREATE_RELATReq (pqkCkzyEkk2L6bRW0Kon4Q)
///  <code>ST_b9515582922fdbd4d217706a5c5c0f3fStructure</code> that represent
/// s <code>ZMXFFIMF_0250_FI_CREATE_RELATReq</code> <p>Description:
///  ZMXFFIMF_0250_FI_CREATE_RELATReq</p>
/// </summary>
// Name: ZMXFFIMF_0250_FI_CREATE_RELATReq
public partial struct ST_b9515582922fdbd4d217706a5c5c0f3fStructure : ITypedRecord<ST_b9515582922fdbd4d217706a5c5c0f3fStructure> {
internal static readonly GlobalObjectKey IdIT_ATTACHMENT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*hhdL9NGLdkKUXcAU1TcZHA");
internal static readonly GlobalObjectKey IdIV_ID = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*8_sHMCbTtE6aBwh8lUIGjQ");
internal static readonly GlobalObjectKey IdIV_SAP_OBJECT = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*4mxEJnMvVk6bERdpUkj3zQ");
internal static readonly GlobalObjectKey IdIV_SAP_OBJECT_ID = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*_QwN4_HFJU6LLE9dWAGApQ");

public RL_cff0038616a202f621fb7082f988995f ssIT_ATTACHMENT;

public string ssIV_ID;

public string ssIV_SAP_OBJECT;

public string ssIV_SAP_OBJECT_ID;


public BitArray OptimizedAttributes;

public ST_b9515582922fdbd4d217706a5c5c0f3fStructure() {
OptimizedAttributes = null;
ssIT_ATTACHMENT = new RL_cff0038616a202f621fb7082f988995f();
ssIV_ID = "";
ssIV_SAP_OBJECT = "";
ssIV_SAP_OBJECT_ID = "";
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
ssIV_ID = r.ReadText(index++, "ZMXFFIMF_0250_FI_CREATE_RELATReq.IV_ID", "");
ssIV_SAP_OBJECT = r.ReadText(index++, "ZMXFFIMF_0250_FI_CREATE_RELATReq.IV_SAP_OBJECT", "");
ssIV_SAP_OBJECT_ID = r.ReadText(index++, "ZMXFFIMF_0250_FI_CREATE_RELATReq.IV_SAP_OBJECT_ID", "");
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
public void ReadIM(ST_b9515582922fdbd4d217706a5c5c0f3fStructure r) {
this = r;
}


public static bool operator == (ST_b9515582922fdbd4d217706a5c5c0f3fStructure a, ST_b9515582922fdbd4d217706a5c5c0f3fStructure b) {
if (a.ssIT_ATTACHMENT != b.ssIT_ATTACHMENT) return false;
if (a.ssIV_ID != b.ssIV_ID) return false;
if (a.ssIV_SAP_OBJECT != b.ssIV_SAP_OBJECT) return false;
if (a.ssIV_SAP_OBJECT_ID != b.ssIV_SAP_OBJECT_ID) return false;
return true;
}

public static bool operator != (ST_b9515582922fdbd4d217706a5c5c0f3fStructure a, ST_b9515582922fdbd4d217706a5c5c0f3fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b9515582922fdbd4d217706a5c5c0f3fStructure)) return false;
return (this == (ST_b9515582922fdbd4d217706a5c5c0f3fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIT_ATTACHMENT.GetHashCode()
 ^ ssIV_ID.GetHashCode()
 ^ ssIV_SAP_OBJECT.GetHashCode()
 ^ ssIV_SAP_OBJECT_ID.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssIT_ATTACHMENT.RecursiveReset();
}

public void InternalRecursiveSave() {
ssIT_ATTACHMENT.InternalRecursiveSave();
}


public ST_b9515582922fdbd4d217706a5c5c0f3fStructure Duplicate() {
ST_b9515582922fdbd4d217706a5c5c0f3fStructure t;
t.ssIT_ATTACHMENT = (RL_cff0038616a202f621fb7082f988995f)this.ssIT_ATTACHMENT.Duplicate();
t.ssIV_ID = this.ssIV_ID;
t.ssIV_SAP_OBJECT = this.ssIV_SAP_OBJECT;
t.ssIV_SAP_OBJECT_ID = this.ssIV_SAP_OBJECT_ID;
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
if (head == "it_attachment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IT_ATTACHMENT")) variable.Value = ssIT_ATTACHMENT; else variable.Optimized = true;
variable.SetFieldName("it_attachment");
} else if (head == "iv_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IV_ID")) variable.Value = ssIV_ID; else variable.Optimized = true;
} else if (head == "iv_sap_object") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IV_SAP_OBJECT")) variable.Value = ssIV_SAP_OBJECT; else variable.Optimized = true;
} else if (head == "iv_sap_object_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IV_SAP_OBJECT_ID")) variable.Value = ssIV_SAP_OBJECT_ID; else variable.Optimized = true;
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
if (key == IdIT_ATTACHMENT) {
return ssIT_ATTACHMENT;
}
if (key == IdIV_ID) {
return ssIV_ID;
}
if (key == IdIV_SAP_OBJECT) {
return ssIV_SAP_OBJECT;
}
if (key == IdIV_SAP_OBJECT_ID) {
return ssIV_SAP_OBJECT_ID;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIT_ATTACHMENT.Key.AsGuid) {
return ssIT_ATTACHMENT;
}
if (attributeKey == IdIV_ID.Key.AsGuid) {
return ssIV_ID;
}
if (attributeKey == IdIV_SAP_OBJECT.Key.AsGuid) {
return ssIV_SAP_OBJECT;
}
if (attributeKey == IdIV_SAP_OBJECT_ID.Key.AsGuid) {
return ssIV_SAP_OBJECT_ID;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIT_ATTACHMENT = new RL_cff0038616a202f621fb7082f988995f();
ssIT_ATTACHMENT.FillFromOther((IOSList) other.AttributeGet(IdIT_ATTACHMENT));
ssIV_ID = (string) other.AttributeGet(IdIV_ID);
ssIV_SAP_OBJECT = (string) other.AttributeGet(IdIV_SAP_OBJECT);
ssIV_SAP_OBJECT_ID = (string) other.AttributeGet(IdIV_SAP_OBJECT_ID);
}
} // ST_b9515582922fdbd4d217706a5c5c0f3fStructure
/// <summary>
/// RecordList type <code>ZMXFFIMF_0250_FI_CREATE_RELATReqList</code> that represents a record list of
///  <code>ZMXFFIMF_0250_FI_CREATE_RELATReq</code>
/// </summary>
public partial class RL_da3db34e6828bb5cdc320a90da2fa7e9 : GenericRecordList<ST_b9515582922fdbd4d217706a5c5c0f3fStructure>, IEnumerable, IEnumerator {

protected override ST_b9515582922fdbd4d217706a5c5c0f3fStructure GetElementDefaultValue() {
return new ST_b9515582922fdbd4d217706a5c5c0f3fStructure();
}

public T[] ToArray<T>(Func<ST_b9515582922fdbd4d217706a5c5c0f3fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da3db34e6828bb5cdc320a90da2fa7e9 recordList, Func<ST_b9515582922fdbd4d217706a5c5c0f3fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da3db34e6828bb5cdc320a90da2fa7e9(ST_b9515582922fdbd4d217706a5c5c0f3fStructure[] array) {
  RL_da3db34e6828bb5cdc320a90da2fa7e9 result = new RL_da3db34e6828bb5cdc320a90da2fa7e9();
result.InnerFromArray(array);
    return result;
}

public static RL_da3db34e6828bb5cdc320a90da2fa7e9 ToList<T>(T[] array, Func <T, ST_b9515582922fdbd4d217706a5c5c0f3fStructure> converter) {
  RL_da3db34e6828bb5cdc320a90da2fa7e9 result = new RL_da3db34e6828bb5cdc320a90da2fa7e9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da3db34e6828bb5cdc320a90da2fa7e9 FromRestList<T>(RestList<T> restList, Func <T, ST_b9515582922fdbd4d217706a5c5c0f3fStructure> converter) {
  RL_da3db34e6828bb5cdc320a90da2fa7e9 result = new RL_da3db34e6828bb5cdc320a90da2fa7e9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da3db34e6828bb5cdc320a90da2fa7e9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b9515582922fdbd4d217706a5c5c0f3fStructure> NewList() {
return new RL_da3db34e6828bb5cdc320a90da2fa7e9();
}


} // RL_da3db34e6828bb5cdc320a90da2fa7e9
}

