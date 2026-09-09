namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (dzWKAlo6xEe1Nf5PnPfqPA)
///  <code>RC_36c38bc61b6c1577adb85f09b017c138</code> that represents <code>OriginRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OriginRecord
public partial struct RC_36c38bc61b6c1577adb85f09b017c138 : ITypedRecord<RC_36c38bc61b6c1577adb85f09b017c138> {
internal static readonly GlobalObjectKey IdOrigin = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xovDNmwbdxWtuF8JsBfBOA");

public EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord ssENOrigin;


public static implicit operator EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord( RC_36c38bc61b6c1577adb85f09b017c138 r) {
return r.ssENOrigin;
}

public static implicit operator RC_36c38bc61b6c1577adb85f09b017c138 (EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord r) {
RC_36c38bc61b6c1577adb85f09b017c138 res = new RC_36c38bc61b6c1577adb85f09b017c138 ();
res.ssENOrigin = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrigin.ChangedAttributes = value;
}
get {
    return ssENOrigin.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_36c38bc61b6c1577adb85f09b017c138() {
OptimizedAttributes = null;
ssENOrigin = new EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrigin.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrigin.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrigin.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrigin.Read( r, ref index);
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
public void ReadIM(RC_36c38bc61b6c1577adb85f09b017c138 r) {
this = r;
}


public static bool operator == (RC_36c38bc61b6c1577adb85f09b017c138 a, RC_36c38bc61b6c1577adb85f09b017c138 b) {
if (a.ssENOrigin != b.ssENOrigin) return false;
return true;
}

public static bool operator != (RC_36c38bc61b6c1577adb85f09b017c138 a, RC_36c38bc61b6c1577adb85f09b017c138 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_36c38bc61b6c1577adb85f09b017c138)) return false;
return (this == (RC_36c38bc61b6c1577adb85f09b017c138)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrigin.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrigin.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrigin.InternalRecursiveSave();
}


public RC_36c38bc61b6c1577adb85f09b017c138 Duplicate() {
RC_36c38bc61b6c1577adb85f09b017c138 t;
t.ssENOrigin = (EN_b98b2c58b0d407a8849d5f07c1b92d57EntityRecord)this.ssENOrigin.Duplicate();
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
if (head == "origin") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Origin")) variable.Value = ssENOrigin; else variable.Optimized = true;
variable.SetFieldName("origin");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrigin.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrigin.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrigin) {
return ssENOrigin;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrigin.Key.AsGuid) {
return ssENOrigin;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrigin.FillFromOther((IRecord) other.AttributeGet(IdOrigin));
}
} // RC_36c38bc61b6c1577adb85f09b017c138
/// <summary>
/// RecordList type <code>OriginRecordList</code> that represents a record list of <code>Origin</code>
/// </summary>
public partial class RL_6e984fcf1dfc5d4a0426bc198ed65dac : GenericRecordList<RC_36c38bc61b6c1577adb85f09b017c138>, IEnumerable, IEnumerator {

protected override RC_36c38bc61b6c1577adb85f09b017c138 GetElementDefaultValue() {
return new RC_36c38bc61b6c1577adb85f09b017c138();
}

public T[] ToArray<T>(Func<RC_36c38bc61b6c1577adb85f09b017c138, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6e984fcf1dfc5d4a0426bc198ed65dac recordList, Func<RC_36c38bc61b6c1577adb85f09b017c138, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6e984fcf1dfc5d4a0426bc198ed65dac(RC_36c38bc61b6c1577adb85f09b017c138[] array) {
  RL_6e984fcf1dfc5d4a0426bc198ed65dac result = new RL_6e984fcf1dfc5d4a0426bc198ed65dac();
result.InnerFromArray(array);
    return result;
}

public static RL_6e984fcf1dfc5d4a0426bc198ed65dac ToList<T>(T[] array, Func <T, RC_36c38bc61b6c1577adb85f09b017c138> converter) {
  RL_6e984fcf1dfc5d4a0426bc198ed65dac result = new RL_6e984fcf1dfc5d4a0426bc198ed65dac();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6e984fcf1dfc5d4a0426bc198ed65dac FromRestList<T>(RestList<T> restList, Func <T, RC_36c38bc61b6c1577adb85f09b017c138> converter) {
  RL_6e984fcf1dfc5d4a0426bc198ed65dac result = new RL_6e984fcf1dfc5d4a0426bc198ed65dac();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6e984fcf1dfc5d4a0426bc198ed65dac() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_36c38bc61b6c1577adb85f09b017c138> NewList() {
return new RL_6e984fcf1dfc5d4a0426bc198ed65dac();
}


} // RL_6e984fcf1dfc5d4a0426bc198ed65dac
}

