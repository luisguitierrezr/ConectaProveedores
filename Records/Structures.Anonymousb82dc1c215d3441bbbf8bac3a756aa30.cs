namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (wsEtuNMVG0S7+LrDp1aqMA)
///  <code>RC_59361fc2fe27e83d1af47e8e07392a42</code> that represent
/// s <code>OrderRetentionTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRetentionTypeRecord
public partial struct RC_59361fc2fe27e83d1af47e8e07392a42 : ITypedRecord<RC_59361fc2fe27e83d1af47e8e07392a42> {
internal static readonly GlobalObjectKey IdOrderRetentionType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wh82WSf+Pega9H6OBzkqQg");

public EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord ssENOrderRetentionType;


public static implicit operator EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord( RC_59361fc2fe27e83d1af47e8e07392a42 r) {
return r.ssENOrderRetentionType;
}

public static implicit operator RC_59361fc2fe27e83d1af47e8e07392a42 (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord r) {
RC_59361fc2fe27e83d1af47e8e07392a42 res = new RC_59361fc2fe27e83d1af47e8e07392a42 ();
res.ssENOrderRetentionType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderRetentionType.ChangedAttributes = value;
}
get {
    return ssENOrderRetentionType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_59361fc2fe27e83d1af47e8e07392a42() {
OptimizedAttributes = null;
ssENOrderRetentionType = new EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRetentionType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderRetentionType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderRetentionType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRetentionType.Read( r, ref index);
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
public void ReadIM(RC_59361fc2fe27e83d1af47e8e07392a42 r) {
this = r;
}


public static bool operator == (RC_59361fc2fe27e83d1af47e8e07392a42 a, RC_59361fc2fe27e83d1af47e8e07392a42 b) {
if (a.ssENOrderRetentionType != b.ssENOrderRetentionType) return false;
return true;
}

public static bool operator != (RC_59361fc2fe27e83d1af47e8e07392a42 a, RC_59361fc2fe27e83d1af47e8e07392a42 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_59361fc2fe27e83d1af47e8e07392a42)) return false;
return (this == (RC_59361fc2fe27e83d1af47e8e07392a42)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRetentionType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRetentionType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRetentionType.InternalRecursiveSave();
}


public RC_59361fc2fe27e83d1af47e8e07392a42 Duplicate() {
RC_59361fc2fe27e83d1af47e8e07392a42 t;
t.ssENOrderRetentionType = (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord)this.ssENOrderRetentionType.Duplicate();
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
if (head == "orderretentiontype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRetentionType")) variable.Value = ssENOrderRetentionType; else variable.Optimized = true;
variable.SetFieldName("orderretentiontype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRetentionType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderRetentionType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderRetentionType) {
return ssENOrderRetentionType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRetentionType.Key.AsGuid) {
return ssENOrderRetentionType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRetentionType.FillFromOther((IRecord) other.AttributeGet(IdOrderRetentionType));
}
} // RC_59361fc2fe27e83d1af47e8e07392a42
/// <summary>
/// RecordList type <code>OrderRetentionTypeRecordList</code> that represents a record list of
///  <code>OrderRetentionType</code>
/// </summary>
public partial class RL_d6a865b9451603b2b07820fedb283c87 : GenericRecordList<RC_59361fc2fe27e83d1af47e8e07392a42>, IEnumerable, IEnumerator {

protected override RC_59361fc2fe27e83d1af47e8e07392a42 GetElementDefaultValue() {
return new RC_59361fc2fe27e83d1af47e8e07392a42();
}

public T[] ToArray<T>(Func<RC_59361fc2fe27e83d1af47e8e07392a42, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d6a865b9451603b2b07820fedb283c87 recordList, Func<RC_59361fc2fe27e83d1af47e8e07392a42, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d6a865b9451603b2b07820fedb283c87(RC_59361fc2fe27e83d1af47e8e07392a42[] array) {
  RL_d6a865b9451603b2b07820fedb283c87 result = new RL_d6a865b9451603b2b07820fedb283c87();
result.InnerFromArray(array);
    return result;
}

public static RL_d6a865b9451603b2b07820fedb283c87 ToList<T>(T[] array, Func <T, RC_59361fc2fe27e83d1af47e8e07392a42> converter) {
  RL_d6a865b9451603b2b07820fedb283c87 result = new RL_d6a865b9451603b2b07820fedb283c87();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d6a865b9451603b2b07820fedb283c87 FromRestList<T>(RestList<T> restList, Func <T, RC_59361fc2fe27e83d1af47e8e07392a42> converter) {
  RL_d6a865b9451603b2b07820fedb283c87 result = new RL_d6a865b9451603b2b07820fedb283c87();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d6a865b9451603b2b07820fedb283c87() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_59361fc2fe27e83d1af47e8e07392a42> NewList() {
return new RL_d6a865b9451603b2b07820fedb283c87();
}


} // RL_d6a865b9451603b2b07820fedb283c87
}

