namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2BNLRhVEL0mNab3TXwBTvQ)
///  <code>RC_2dc2cf38bcc16a8b338dc5ea9a5c6446</code> that represents <code>OrderAccountingRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderAccountingRecord
public partial struct RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 : ITypedRecord<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> {
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;


public static implicit operator EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord( RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 r) {
return r.ssENOrderAccounting;
}

public static implicit operator RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord r) {
RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 res = new RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 ();
res.ssENOrderAccounting = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderAccounting.ChangedAttributes = value;
}
get {
    return ssENOrderAccounting.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2dc2cf38bcc16a8b338dc5ea9a5c6446() {
OptimizedAttributes = null;
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderAccounting.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderAccounting.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderAccounting.Read( r, ref index);
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
public void ReadIM(RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 r) {
this = r;
}


public static bool operator == (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 a, RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 b) {
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
return true;
}

public static bool operator != (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 a, RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446)) return false;
return (this == (RC_2dc2cf38bcc16a8b338dc5ea9a5c6446)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccounting.InternalRecursiveSave();
}


public RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 Duplicate() {
RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 t;
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
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
if (head == "orderaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccounting")) variable.Value = ssENOrderAccounting; else variable.Optimized = true;
variable.SetFieldName("orderaccounting");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderAccounting.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderAccounting.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderAccounting) {
return ssENOrderAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccounting.Key.AsGuid) {
return ssENOrderAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccounting.FillFromOther((IRecord) other.AttributeGet(IdOrderAccounting));
}
} // RC_2dc2cf38bcc16a8b338dc5ea9a5c6446
/// <summary>
/// RecordList type <code>OrderAccountingRecordList</code> that represents a record list of
///  <code>OrderAccounting</code>
/// </summary>
public partial class RL_aedf606f6413243cfacf43ac13db404f : GenericRecordList<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446>, IEnumerable, IEnumerator {

protected override RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 GetElementDefaultValue() {
return new RC_2dc2cf38bcc16a8b338dc5ea9a5c6446();
}

public T[] ToArray<T>(Func<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aedf606f6413243cfacf43ac13db404f recordList, Func<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aedf606f6413243cfacf43ac13db404f(RC_2dc2cf38bcc16a8b338dc5ea9a5c6446[] array) {
  RL_aedf606f6413243cfacf43ac13db404f result = new RL_aedf606f6413243cfacf43ac13db404f();
result.InnerFromArray(array);
    return result;
}

public static RL_aedf606f6413243cfacf43ac13db404f ToList<T>(T[] array, Func <T, RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> converter) {
  RL_aedf606f6413243cfacf43ac13db404f result = new RL_aedf606f6413243cfacf43ac13db404f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aedf606f6413243cfacf43ac13db404f FromRestList<T>(RestList<T> restList, Func <T, RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> converter) {
  RL_aedf606f6413243cfacf43ac13db404f result = new RL_aedf606f6413243cfacf43ac13db404f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aedf606f6413243cfacf43ac13db404f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> NewList() {
return new RL_aedf606f6413243cfacf43ac13db404f();
}


} // RL_aedf606f6413243cfacf43ac13db404f
}

