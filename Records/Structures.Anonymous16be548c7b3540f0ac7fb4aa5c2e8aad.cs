namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jFS+FjV78ECsf7SqXC6KrQ)
///  <code>RC_7b1aae62a8e090753ba4cda6cb9c5acd</code> that represent
/// s <code>FolioItemForOrderRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioItemForOrderRecord
public partial struct RC_7b1aae62a8e090753ba4cda6cb9c5acd : ITypedRecord<RC_7b1aae62a8e090753ba4cda6cb9c5acd> {
internal static readonly GlobalObjectKey IdFolioItemForOrder = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Yq4ae+CodZA7pM2my5xazQ");

public ST_662e235c01358293d93e19bedad72008Structure ssSTFolioItemForOrder;


public static implicit operator ST_662e235c01358293d93e19bedad72008Structure( RC_7b1aae62a8e090753ba4cda6cb9c5acd r) {
return r.ssSTFolioItemForOrder;
}

public static implicit operator RC_7b1aae62a8e090753ba4cda6cb9c5acd (ST_662e235c01358293d93e19bedad72008Structure r) {
RC_7b1aae62a8e090753ba4cda6cb9c5acd res = new RC_7b1aae62a8e090753ba4cda6cb9c5acd ();
res.ssSTFolioItemForOrder = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7b1aae62a8e090753ba4cda6cb9c5acd() {
OptimizedAttributes = null;
ssSTFolioItemForOrder = new ST_662e235c01358293d93e19bedad72008Structure();
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
    ssSTFolioItemForOrder.OptimizedAttributes = value[0];
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
ssSTFolioItemForOrder.Read( r, ref index);
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
public void ReadIM(RC_7b1aae62a8e090753ba4cda6cb9c5acd r) {
this = r;
}


public static bool operator == (RC_7b1aae62a8e090753ba4cda6cb9c5acd a, RC_7b1aae62a8e090753ba4cda6cb9c5acd b) {
if (a.ssSTFolioItemForOrder != b.ssSTFolioItemForOrder) return false;
return true;
}

public static bool operator != (RC_7b1aae62a8e090753ba4cda6cb9c5acd a, RC_7b1aae62a8e090753ba4cda6cb9c5acd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7b1aae62a8e090753ba4cda6cb9c5acd)) return false;
return (this == (RC_7b1aae62a8e090753ba4cda6cb9c5acd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioItemForOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioItemForOrder.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioItemForOrder.InternalRecursiveSave();
}


public RC_7b1aae62a8e090753ba4cda6cb9c5acd Duplicate() {
RC_7b1aae62a8e090753ba4cda6cb9c5acd t;
t.ssSTFolioItemForOrder = (ST_662e235c01358293d93e19bedad72008Structure)this.ssSTFolioItemForOrder.Duplicate();
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
if (head == "folioitemfororder") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItemForOrder")) variable.Value = ssSTFolioItemForOrder; else variable.Optimized = true;
variable.SetFieldName("folioitemfororder");
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
if (key == IdFolioItemForOrder) {
return ssSTFolioItemForOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioItemForOrder.Key.AsGuid) {
return ssSTFolioItemForOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioItemForOrder.FillFromOther((IRecord) other.AttributeGet(IdFolioItemForOrder));
}
} // RC_7b1aae62a8e090753ba4cda6cb9c5acd
/// <summary>
/// RecordList type <code>FolioItemForOrderRecordList</code> that represents a record list of
///  <code>FolioItemForOrder</code>
/// </summary>
public partial class RL_655c0a8b64ba745fe765edb883275714 : GenericRecordList<RC_7b1aae62a8e090753ba4cda6cb9c5acd>, IEnumerable, IEnumerator {

protected override RC_7b1aae62a8e090753ba4cda6cb9c5acd GetElementDefaultValue() {
return new RC_7b1aae62a8e090753ba4cda6cb9c5acd();
}

public T[] ToArray<T>(Func<RC_7b1aae62a8e090753ba4cda6cb9c5acd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_655c0a8b64ba745fe765edb883275714 recordList, Func<RC_7b1aae62a8e090753ba4cda6cb9c5acd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_655c0a8b64ba745fe765edb883275714(RC_7b1aae62a8e090753ba4cda6cb9c5acd[] array) {
  RL_655c0a8b64ba745fe765edb883275714 result = new RL_655c0a8b64ba745fe765edb883275714();
result.InnerFromArray(array);
    return result;
}

public static RL_655c0a8b64ba745fe765edb883275714 ToList<T>(T[] array, Func <T, RC_7b1aae62a8e090753ba4cda6cb9c5acd> converter) {
  RL_655c0a8b64ba745fe765edb883275714 result = new RL_655c0a8b64ba745fe765edb883275714();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_655c0a8b64ba745fe765edb883275714 FromRestList<T>(RestList<T> restList, Func <T, RC_7b1aae62a8e090753ba4cda6cb9c5acd> converter) {
  RL_655c0a8b64ba745fe765edb883275714 result = new RL_655c0a8b64ba745fe765edb883275714();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_655c0a8b64ba745fe765edb883275714() : base() {
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
protected override OSList<RC_7b1aae62a8e090753ba4cda6cb9c5acd> NewList() {
return new RL_655c0a8b64ba745fe765edb883275714();
}


} // RL_655c0a8b64ba745fe765edb883275714
}

