using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] ScrollbarStyle (KFPhdwF3HkSiJ3dPT9IOhw)
///  <code>EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord</code> that represent
/// s <code>ScrollbarStyle</code> <p>Description: Contains different scrollbsr styles.</p>
/// </summary>
// Name: ScrollbarStyle
public partial struct EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord : ITypedRecord<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> {
internal static readonly GlobalObjectKey IdStyle = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*VLm0YxAfgUWYdcC7lkZMBw");

private string _ssStyle;
public string ssStyle{
  get{
      return _ssStyle;
  }
  set{
      if((_ssStyle!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssStyle = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssStyle = "";
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
ssStyle = r.ReadText(index++, "ScrollbarStyle.Style", "");
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord r) {
this = r;
}


public static bool operator == (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord a, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord b) {
if (a.ssStyle != b.ssStyle) return false;
return true;
}

public static bool operator != (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord a, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord)) return false;
return (this == (EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssStyle.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord Duplicate() {
EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord t;
t._ssStyle = this._ssStyle;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "style") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Style")) variable.Value = ssStyle; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdStyle)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdStyle)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdStyle) {
return ssStyle;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStyle.Key.AsGuid) {
return ssStyle;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssStyle = (string) other.AttributeGet(IdStyle);
ChangedAttributes[0] = other.ChangedAttributeGet(IdStyle);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdStyle);
}
} // EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord

/// <summary>
/// RecordList type <code>ScrollbarStyleList</code> that represents a record list of
///  <code>ScrollbarStyle</code>
/// </summary>
public partial class RL_d2c71de812e44763974172e04508cef5 : GenericRecordList<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord>, IEnumerable, IEnumerator {

protected override EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord GetElementDefaultValue() {
return new EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord();
}

public T[] ToArray<T>(Func<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d2c71de812e44763974172e04508cef5 recordList, Func<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d2c71de812e44763974172e04508cef5(EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord[] array) {
  RL_d2c71de812e44763974172e04508cef5 result = new RL_d2c71de812e44763974172e04508cef5();
result.InnerFromArray(array);
    return result;
}

public static RL_d2c71de812e44763974172e04508cef5 ToList<T>(T[] array, Func <T, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> converter) {
  RL_d2c71de812e44763974172e04508cef5 result = new RL_d2c71de812e44763974172e04508cef5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d2c71de812e44763974172e04508cef5 FromRestList<T>(RestList<T> restList, Func <T, EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> converter) {
  RL_d2c71de812e44763974172e04508cef5 result = new RL_d2c71de812e44763974172e04508cef5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d2c71de812e44763974172e04508cef5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1967a79b0bc6b1bdc38ff87eefe0b127EntityRecord> NewList() {
return new RL_d2c71de812e44763974172e04508cef5();
}


} // RL_d2c71de812e44763974172e04508cef5
}
