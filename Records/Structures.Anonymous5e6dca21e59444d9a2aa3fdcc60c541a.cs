namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IcptXpTl2USiqj_cxgxUGg)
///  <code>RC_10f704d4de8999e255a09f6b1b9b5668</code> that represents <code>DocumentTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DocumentTypeRecord
public partial struct RC_10f704d4de8999e255a09f6b1b9b5668 : ITypedRecord<RC_10f704d4de8999e255a09f6b1b9b5668> {
internal static readonly GlobalObjectKey IdDocumentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1AT3EIne4plVoJ9rG5tWaA");

public EN_a70d553ce1458b3952d039852f258a76EntityRecord ssENDocumentType;


public static implicit operator EN_a70d553ce1458b3952d039852f258a76EntityRecord( RC_10f704d4de8999e255a09f6b1b9b5668 r) {
return r.ssENDocumentType;
}

public static implicit operator RC_10f704d4de8999e255a09f6b1b9b5668 (EN_a70d553ce1458b3952d039852f258a76EntityRecord r) {
RC_10f704d4de8999e255a09f6b1b9b5668 res = new RC_10f704d4de8999e255a09f6b1b9b5668 ();
res.ssENDocumentType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDocumentType.ChangedAttributes = value;
}
get {
    return ssENDocumentType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_10f704d4de8999e255a09f6b1b9b5668() {
OptimizedAttributes = null;
ssENDocumentType = new EN_a70d553ce1458b3952d039852f258a76EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDocumentType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDocumentType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDocumentType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDocumentType.Read( r, ref index);
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
public void ReadIM(RC_10f704d4de8999e255a09f6b1b9b5668 r) {
this = r;
}


public static bool operator == (RC_10f704d4de8999e255a09f6b1b9b5668 a, RC_10f704d4de8999e255a09f6b1b9b5668 b) {
if (a.ssENDocumentType != b.ssENDocumentType) return false;
return true;
}

public static bool operator != (RC_10f704d4de8999e255a09f6b1b9b5668 a, RC_10f704d4de8999e255a09f6b1b9b5668 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_10f704d4de8999e255a09f6b1b9b5668)) return false;
return (this == (RC_10f704d4de8999e255a09f6b1b9b5668)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDocumentType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDocumentType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDocumentType.InternalRecursiveSave();
}


public RC_10f704d4de8999e255a09f6b1b9b5668 Duplicate() {
RC_10f704d4de8999e255a09f6b1b9b5668 t;
t.ssENDocumentType = (EN_a70d553ce1458b3952d039852f258a76EntityRecord)this.ssENDocumentType.Duplicate();
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
if (head == "documenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentType")) variable.Value = ssENDocumentType; else variable.Optimized = true;
variable.SetFieldName("documenttype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDocumentType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDocumentType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDocumentType) {
return ssENDocumentType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentType.Key.AsGuid) {
return ssENDocumentType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDocumentType.FillFromOther((IRecord) other.AttributeGet(IdDocumentType));
}
} // RC_10f704d4de8999e255a09f6b1b9b5668
/// <summary>
/// RecordList type <code>DocumentTypeRecordList</code> that represents a record list of
///  <code>DocumentType</code>
/// </summary>
public partial class RL_f2d249f675a5073e98f93433009d7ad4 : GenericRecordList<RC_10f704d4de8999e255a09f6b1b9b5668>, IEnumerable, IEnumerator {

protected override RC_10f704d4de8999e255a09f6b1b9b5668 GetElementDefaultValue() {
return new RC_10f704d4de8999e255a09f6b1b9b5668();
}

public T[] ToArray<T>(Func<RC_10f704d4de8999e255a09f6b1b9b5668, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f2d249f675a5073e98f93433009d7ad4 recordList, Func<RC_10f704d4de8999e255a09f6b1b9b5668, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f2d249f675a5073e98f93433009d7ad4(RC_10f704d4de8999e255a09f6b1b9b5668[] array) {
  RL_f2d249f675a5073e98f93433009d7ad4 result = new RL_f2d249f675a5073e98f93433009d7ad4();
result.InnerFromArray(array);
    return result;
}

public static RL_f2d249f675a5073e98f93433009d7ad4 ToList<T>(T[] array, Func <T, RC_10f704d4de8999e255a09f6b1b9b5668> converter) {
  RL_f2d249f675a5073e98f93433009d7ad4 result = new RL_f2d249f675a5073e98f93433009d7ad4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f2d249f675a5073e98f93433009d7ad4 FromRestList<T>(RestList<T> restList, Func <T, RC_10f704d4de8999e255a09f6b1b9b5668> converter) {
  RL_f2d249f675a5073e98f93433009d7ad4 result = new RL_f2d249f675a5073e98f93433009d7ad4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f2d249f675a5073e98f93433009d7ad4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_10f704d4de8999e255a09f6b1b9b5668> NewList() {
return new RL_f2d249f675a5073e98f93433009d7ad4();
}


} // RL_f2d249f675a5073e98f93433009d7ad4
}

