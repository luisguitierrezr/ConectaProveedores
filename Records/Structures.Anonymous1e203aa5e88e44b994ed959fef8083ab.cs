namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pTogHo7ouUSU7ZWf74CDqw)
///  <code>RC_56805fdef6332e01f13c0f9217357dbc</code> that represents <code>DropdownItemRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DropdownItemRecord
public partial struct RC_56805fdef6332e01f13c0f9217357dbc : ITypedRecord<RC_56805fdef6332e01f13c0f9217357dbc> {
internal static readonly GlobalObjectKey IdDropdownItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3l+AVjP2AS7xPA+SFzV9vA");

public ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure ssSTDropdownItem;


public static implicit operator ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure( RC_56805fdef6332e01f13c0f9217357dbc r) {
return r.ssSTDropdownItem;
}

public static implicit operator RC_56805fdef6332e01f13c0f9217357dbc (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure r) {
RC_56805fdef6332e01f13c0f9217357dbc res = new RC_56805fdef6332e01f13c0f9217357dbc ();
res.ssSTDropdownItem = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_56805fdef6332e01f13c0f9217357dbc() {
OptimizedAttributes = null;
ssSTDropdownItem = new ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTDropdownItem.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTDropdownItem.Read( r, ref index);
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
public void ReadIM(RC_56805fdef6332e01f13c0f9217357dbc r) {
this = r;
}


public static bool operator == (RC_56805fdef6332e01f13c0f9217357dbc a, RC_56805fdef6332e01f13c0f9217357dbc b) {
if (a.ssSTDropdownItem != b.ssSTDropdownItem) return false;
return true;
}

public static bool operator != (RC_56805fdef6332e01f13c0f9217357dbc a, RC_56805fdef6332e01f13c0f9217357dbc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_56805fdef6332e01f13c0f9217357dbc)) return false;
return (this == (RC_56805fdef6332e01f13c0f9217357dbc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDropdownItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDropdownItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDropdownItem.InternalRecursiveSave();
}


public RC_56805fdef6332e01f13c0f9217357dbc Duplicate() {
RC_56805fdef6332e01f13c0f9217357dbc t;
t.ssSTDropdownItem = (ST_3cb059eb7f6ed8c9a730f87011d5c0e0Structure)this.ssSTDropdownItem.Duplicate();
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
if (head == "dropdownitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DropdownItem")) variable.Value = ssSTDropdownItem; else variable.Optimized = true;
variable.SetFieldName("dropdownitem");
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
if (key == IdDropdownItem) {
return ssSTDropdownItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDropdownItem.Key.AsGuid) {
return ssSTDropdownItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDropdownItem.FillFromOther((IRecord) other.AttributeGet(IdDropdownItem));
}
} // RC_56805fdef6332e01f13c0f9217357dbc
/// <summary>
/// RecordList type <code>DropdownItemRecordList</code> that represents a record list of
///  <code>DropdownItem</code>
/// </summary>
public partial class RL_d8959d4c81c965e073d03471f545ed85 : GenericRecordList<RC_56805fdef6332e01f13c0f9217357dbc>, IEnumerable, IEnumerator {

protected override RC_56805fdef6332e01f13c0f9217357dbc GetElementDefaultValue() {
return new RC_56805fdef6332e01f13c0f9217357dbc();
}

public T[] ToArray<T>(Func<RC_56805fdef6332e01f13c0f9217357dbc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8959d4c81c965e073d03471f545ed85 recordList, Func<RC_56805fdef6332e01f13c0f9217357dbc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8959d4c81c965e073d03471f545ed85(RC_56805fdef6332e01f13c0f9217357dbc[] array) {
  RL_d8959d4c81c965e073d03471f545ed85 result = new RL_d8959d4c81c965e073d03471f545ed85();
result.InnerFromArray(array);
    return result;
}

public static RL_d8959d4c81c965e073d03471f545ed85 ToList<T>(T[] array, Func <T, RC_56805fdef6332e01f13c0f9217357dbc> converter) {
  RL_d8959d4c81c965e073d03471f545ed85 result = new RL_d8959d4c81c965e073d03471f545ed85();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8959d4c81c965e073d03471f545ed85 FromRestList<T>(RestList<T> restList, Func <T, RC_56805fdef6332e01f13c0f9217357dbc> converter) {
  RL_d8959d4c81c965e073d03471f545ed85 result = new RL_d8959d4c81c965e073d03471f545ed85();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8959d4c81c965e073d03471f545ed85() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_56805fdef6332e01f13c0f9217357dbc> NewList() {
return new RL_d8959d4c81c965e073d03471f545ed85();
}


} // RL_d8959d4c81c965e073d03471f545ed85
}

