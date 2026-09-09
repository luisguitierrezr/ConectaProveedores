namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Ag4hhNOZh02N3Qr2OMhAEg)
///  <code>RC_2cd8ef4429a3040401080390a43c2ddc</code> that represents <code>EntryBlockDatesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EntryBlockDatesRecord
public partial struct RC_2cd8ef4429a3040401080390a43c2ddc : ITypedRecord<RC_2cd8ef4429a3040401080390a43c2ddc> {
internal static readonly GlobalObjectKey IdEntryBlockDates = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RO_YLKMpBAQBCAOQpDwt3A");

public EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord ssENEntryBlockDates;


public static implicit operator EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord( RC_2cd8ef4429a3040401080390a43c2ddc r) {
return r.ssENEntryBlockDates;
}

public static implicit operator RC_2cd8ef4429a3040401080390a43c2ddc (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord r) {
RC_2cd8ef4429a3040401080390a43c2ddc res = new RC_2cd8ef4429a3040401080390a43c2ddc ();
res.ssENEntryBlockDates = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENEntryBlockDates.ChangedAttributes = value;
}
get {
    return ssENEntryBlockDates.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2cd8ef4429a3040401080390a43c2ddc() {
OptimizedAttributes = null;
ssENEntryBlockDates = new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENEntryBlockDates.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENEntryBlockDates.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENEntryBlockDates.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENEntryBlockDates.Read( r, ref index);
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
public void ReadIM(RC_2cd8ef4429a3040401080390a43c2ddc r) {
this = r;
}


public static bool operator == (RC_2cd8ef4429a3040401080390a43c2ddc a, RC_2cd8ef4429a3040401080390a43c2ddc b) {
if (a.ssENEntryBlockDates != b.ssENEntryBlockDates) return false;
return true;
}

public static bool operator != (RC_2cd8ef4429a3040401080390a43c2ddc a, RC_2cd8ef4429a3040401080390a43c2ddc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2cd8ef4429a3040401080390a43c2ddc)) return false;
return (this == (RC_2cd8ef4429a3040401080390a43c2ddc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENEntryBlockDates.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENEntryBlockDates.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENEntryBlockDates.InternalRecursiveSave();
}


public RC_2cd8ef4429a3040401080390a43c2ddc Duplicate() {
RC_2cd8ef4429a3040401080390a43c2ddc t;
t.ssENEntryBlockDates = (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord)this.ssENEntryBlockDates.Duplicate();
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
if (head == "entryblockdates") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryBlockDates")) variable.Value = ssENEntryBlockDates; else variable.Optimized = true;
variable.SetFieldName("entryblockdates");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENEntryBlockDates.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENEntryBlockDates.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdEntryBlockDates) {
return ssENEntryBlockDates;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntryBlockDates.Key.AsGuid) {
return ssENEntryBlockDates;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENEntryBlockDates.FillFromOther((IRecord) other.AttributeGet(IdEntryBlockDates));
}
} // RC_2cd8ef4429a3040401080390a43c2ddc
/// <summary>
/// RecordList type <code>EntryBlockDatesRecordList</code> that represents a record list of
///  <code>EntryBlockDates</code>
/// </summary>
public partial class RL_457592c76b13958389afa92eb179006c : GenericRecordList<RC_2cd8ef4429a3040401080390a43c2ddc>, IEnumerable, IEnumerator {

protected override RC_2cd8ef4429a3040401080390a43c2ddc GetElementDefaultValue() {
return new RC_2cd8ef4429a3040401080390a43c2ddc();
}

public T[] ToArray<T>(Func<RC_2cd8ef4429a3040401080390a43c2ddc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_457592c76b13958389afa92eb179006c recordList, Func<RC_2cd8ef4429a3040401080390a43c2ddc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_457592c76b13958389afa92eb179006c(RC_2cd8ef4429a3040401080390a43c2ddc[] array) {
  RL_457592c76b13958389afa92eb179006c result = new RL_457592c76b13958389afa92eb179006c();
result.InnerFromArray(array);
    return result;
}

public static RL_457592c76b13958389afa92eb179006c ToList<T>(T[] array, Func <T, RC_2cd8ef4429a3040401080390a43c2ddc> converter) {
  RL_457592c76b13958389afa92eb179006c result = new RL_457592c76b13958389afa92eb179006c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_457592c76b13958389afa92eb179006c FromRestList<T>(RestList<T> restList, Func <T, RC_2cd8ef4429a3040401080390a43c2ddc> converter) {
  RL_457592c76b13958389afa92eb179006c result = new RL_457592c76b13958389afa92eb179006c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_457592c76b13958389afa92eb179006c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2cd8ef4429a3040401080390a43c2ddc> NewList() {
return new RL_457592c76b13958389afa92eb179006c();
}


} // RL_457592c76b13958389afa92eb179006c
}

