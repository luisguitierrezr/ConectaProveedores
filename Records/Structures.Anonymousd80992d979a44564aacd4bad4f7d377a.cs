namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2ZIJ2KR5ZEWqzUutT303eg)
///  <code>RC_919d72dc5292e812597af4fac0a808e4</code> that represents <code>OrderStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderStatusRecord
public partial struct RC_919d72dc5292e812597af4fac0a808e4 : ITypedRecord<RC_919d72dc5292e812597af4fac0a808e4> {
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;


public static implicit operator EN_5eda60810da752f579e01795bb7e0de0EntityRecord( RC_919d72dc5292e812597af4fac0a808e4 r) {
return r.ssENOrderStatus;
}

public static implicit operator RC_919d72dc5292e812597af4fac0a808e4 (EN_5eda60810da752f579e01795bb7e0de0EntityRecord r) {
RC_919d72dc5292e812597af4fac0a808e4 res = new RC_919d72dc5292e812597af4fac0a808e4 ();
res.ssENOrderStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderStatus.ChangedAttributes = value;
}
get {
    return ssENOrderStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_919d72dc5292e812597af4fac0a808e4() {
OptimizedAttributes = null;
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderStatus.Read( r, ref index);
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
public void ReadIM(RC_919d72dc5292e812597af4fac0a808e4 r) {
this = r;
}


public static bool operator == (RC_919d72dc5292e812597af4fac0a808e4 a, RC_919d72dc5292e812597af4fac0a808e4 b) {
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
return true;
}

public static bool operator != (RC_919d72dc5292e812597af4fac0a808e4 a, RC_919d72dc5292e812597af4fac0a808e4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_919d72dc5292e812597af4fac0a808e4)) return false;
return (this == (RC_919d72dc5292e812597af4fac0a808e4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderStatus.InternalRecursiveSave();
}


public RC_919d72dc5292e812597af4fac0a808e4 Duplicate() {
RC_919d72dc5292e812597af4fac0a808e4 t;
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
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
if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
}
} // RC_919d72dc5292e812597af4fac0a808e4
/// <summary>
/// RecordList type <code>OrderStatusRecordList</code> that represents a record list of
///  <code>OrderStatus</code>
/// </summary>
public partial class RL_cf716c649767b1312d0b25fa52ff2f38 : GenericRecordList<RC_919d72dc5292e812597af4fac0a808e4>, IEnumerable, IEnumerator {

protected override RC_919d72dc5292e812597af4fac0a808e4 GetElementDefaultValue() {
return new RC_919d72dc5292e812597af4fac0a808e4();
}

public T[] ToArray<T>(Func<RC_919d72dc5292e812597af4fac0a808e4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cf716c649767b1312d0b25fa52ff2f38 recordList, Func<RC_919d72dc5292e812597af4fac0a808e4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cf716c649767b1312d0b25fa52ff2f38(RC_919d72dc5292e812597af4fac0a808e4[] array) {
  RL_cf716c649767b1312d0b25fa52ff2f38 result = new RL_cf716c649767b1312d0b25fa52ff2f38();
result.InnerFromArray(array);
    return result;
}

public static RL_cf716c649767b1312d0b25fa52ff2f38 ToList<T>(T[] array, Func <T, RC_919d72dc5292e812597af4fac0a808e4> converter) {
  RL_cf716c649767b1312d0b25fa52ff2f38 result = new RL_cf716c649767b1312d0b25fa52ff2f38();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cf716c649767b1312d0b25fa52ff2f38 FromRestList<T>(RestList<T> restList, Func <T, RC_919d72dc5292e812597af4fac0a808e4> converter) {
  RL_cf716c649767b1312d0b25fa52ff2f38 result = new RL_cf716c649767b1312d0b25fa52ff2f38();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cf716c649767b1312d0b25fa52ff2f38() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_919d72dc5292e812597af4fac0a808e4> NewList() {
return new RL_cf716c649767b1312d0b25fa52ff2f38();
}


} // RL_cf716c649767b1312d0b25fa52ff2f38
}

