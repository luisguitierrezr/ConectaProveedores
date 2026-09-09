namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (LGVg9v8dL02ktDYJAPL_kA)
///  <code>RC_ab72f035aa34ddb5ec313dc02adb1f18</code> that represent
/// s <code>AccordionIconPositionRecord</code> <p>Description: </p>
/// </summary>
// Name: AccordionIconPositionRecord
public partial struct RC_ab72f035aa34ddb5ec313dc02adb1f18 : ITypedRecord<RC_ab72f035aa34ddb5ec313dc02adb1f18> {
internal static readonly GlobalObjectKey IdAccordionIconPosition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NfByqzSqtd3sMT3AKtsfGA");

public EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord ssENAccordionIconPosition;


public static implicit operator EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord( RC_ab72f035aa34ddb5ec313dc02adb1f18 r) {
return r.ssENAccordionIconPosition;
}

public static implicit operator RC_ab72f035aa34ddb5ec313dc02adb1f18 (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord r) {
RC_ab72f035aa34ddb5ec313dc02adb1f18 res = new RC_ab72f035aa34ddb5ec313dc02adb1f18 ();
res.ssENAccordionIconPosition = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAccordionIconPosition.ChangedAttributes = value;
}
get {
    return ssENAccordionIconPosition.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ab72f035aa34ddb5ec313dc02adb1f18() {
OptimizedAttributes = null;
ssENAccordionIconPosition = new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAccordionIconPosition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAccordionIconPosition.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAccordionIconPosition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAccordionIconPosition.Read( r, ref index);
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
public void ReadIM(RC_ab72f035aa34ddb5ec313dc02adb1f18 r) {
this = r;
}


public static bool operator == (RC_ab72f035aa34ddb5ec313dc02adb1f18 a, RC_ab72f035aa34ddb5ec313dc02adb1f18 b) {
if (a.ssENAccordionIconPosition != b.ssENAccordionIconPosition) return false;
return true;
}

public static bool operator != (RC_ab72f035aa34ddb5ec313dc02adb1f18 a, RC_ab72f035aa34ddb5ec313dc02adb1f18 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ab72f035aa34ddb5ec313dc02adb1f18)) return false;
return (this == (RC_ab72f035aa34ddb5ec313dc02adb1f18)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAccordionIconPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAccordionIconPosition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAccordionIconPosition.InternalRecursiveSave();
}


public RC_ab72f035aa34ddb5ec313dc02adb1f18 Duplicate() {
RC_ab72f035aa34ddb5ec313dc02adb1f18 t;
t.ssENAccordionIconPosition = (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord)this.ssENAccordionIconPosition.Duplicate();
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
if (head == "accordioniconposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccordionIconPosition")) variable.Value = ssENAccordionIconPosition; else variable.Optimized = true;
variable.SetFieldName("accordioniconposition");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAccordionIconPosition.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAccordionIconPosition.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAccordionIconPosition) {
return ssENAccordionIconPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccordionIconPosition.Key.AsGuid) {
return ssENAccordionIconPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAccordionIconPosition.FillFromOther((IRecord) other.AttributeGet(IdAccordionIconPosition));
}
} // RC_ab72f035aa34ddb5ec313dc02adb1f18
/// <summary>
/// RecordList type <code>AccordionIconPositionRecordList</code> that represents a record list of
///  <code>AccordionIconPosition</code>
/// </summary>
public partial class RL_996fbee06ca423494c6785889a54264f : GenericRecordList<RC_ab72f035aa34ddb5ec313dc02adb1f18>, IEnumerable, IEnumerator {

protected override RC_ab72f035aa34ddb5ec313dc02adb1f18 GetElementDefaultValue() {
return new RC_ab72f035aa34ddb5ec313dc02adb1f18();
}

public T[] ToArray<T>(Func<RC_ab72f035aa34ddb5ec313dc02adb1f18, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_996fbee06ca423494c6785889a54264f recordList, Func<RC_ab72f035aa34ddb5ec313dc02adb1f18, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_996fbee06ca423494c6785889a54264f(RC_ab72f035aa34ddb5ec313dc02adb1f18[] array) {
  RL_996fbee06ca423494c6785889a54264f result = new RL_996fbee06ca423494c6785889a54264f();
result.InnerFromArray(array);
    return result;
}

public static RL_996fbee06ca423494c6785889a54264f ToList<T>(T[] array, Func <T, RC_ab72f035aa34ddb5ec313dc02adb1f18> converter) {
  RL_996fbee06ca423494c6785889a54264f result = new RL_996fbee06ca423494c6785889a54264f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_996fbee06ca423494c6785889a54264f FromRestList<T>(RestList<T> restList, Func <T, RC_ab72f035aa34ddb5ec313dc02adb1f18> converter) {
  RL_996fbee06ca423494c6785889a54264f result = new RL_996fbee06ca423494c6785889a54264f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_996fbee06ca423494c6785889a54264f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ab72f035aa34ddb5ec313dc02adb1f18> NewList() {
return new RL_996fbee06ca423494c6785889a54264f();
}


} // RL_996fbee06ca423494c6785889a54264f
}

