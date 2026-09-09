namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pM+CfeQs6EmVyZRVUTg+nQ)
///  <code>RC_7fd286c48691331601c5027580ae5af5</code> that represents <code>FolioSAPDataRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioSAPDataRecord
public partial struct RC_7fd286c48691331601c5027580ae5af5 : ITypedRecord<RC_7fd286c48691331601c5027580ae5af5> {
internal static readonly GlobalObjectKey IdFolioSAPData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xIbSf5GGFjMBxQJ1gK5a9Q");

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData;


public static implicit operator EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord( RC_7fd286c48691331601c5027580ae5af5 r) {
return r.ssENFolioSAPData;
}

public static implicit operator RC_7fd286c48691331601c5027580ae5af5 (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord r) {
RC_7fd286c48691331601c5027580ae5af5 res = new RC_7fd286c48691331601c5027580ae5af5 ();
res.ssENFolioSAPData = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioSAPData.ChangedAttributes = value;
}
get {
    return ssENFolioSAPData.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_7fd286c48691331601c5027580ae5af5() {
OptimizedAttributes = null;
ssENFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(15,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioSAPData.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioSAPData.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioSAPData.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioSAPData.Read( r, ref index);
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
public void ReadIM(RC_7fd286c48691331601c5027580ae5af5 r) {
this = r;
}


public static bool operator == (RC_7fd286c48691331601c5027580ae5af5 a, RC_7fd286c48691331601c5027580ae5af5 b) {
if (a.ssENFolioSAPData != b.ssENFolioSAPData) return false;
return true;
}

public static bool operator != (RC_7fd286c48691331601c5027580ae5af5 a, RC_7fd286c48691331601c5027580ae5af5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7fd286c48691331601c5027580ae5af5)) return false;
return (this == (RC_7fd286c48691331601c5027580ae5af5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioSAPData.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioSAPData.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioSAPData.InternalRecursiveSave();
}


public RC_7fd286c48691331601c5027580ae5af5 Duplicate() {
RC_7fd286c48691331601c5027580ae5af5 t;
t.ssENFolioSAPData = (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)this.ssENFolioSAPData.Duplicate();
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
if (head == "foliosapdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioSAPData")) variable.Value = ssENFolioSAPData; else variable.Optimized = true;
variable.SetFieldName("foliosapdata");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioSAPData.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioSAPData.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioSAPData) {
return ssENFolioSAPData;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioSAPData.Key.AsGuid) {
return ssENFolioSAPData;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioSAPData.FillFromOther((IRecord) other.AttributeGet(IdFolioSAPData));
}
} // RC_7fd286c48691331601c5027580ae5af5
/// <summary>
/// RecordList type <code>FolioSAPDataRecordList</code> that represents a record list of
///  <code>FolioSAPData</code>
/// </summary>
public partial class RL_c9f6aa71e71ab2513c8b708a5c8313ba : GenericRecordList<RC_7fd286c48691331601c5027580ae5af5>, IEnumerable, IEnumerator {

protected override RC_7fd286c48691331601c5027580ae5af5 GetElementDefaultValue() {
return new RC_7fd286c48691331601c5027580ae5af5();
}

public T[] ToArray<T>(Func<RC_7fd286c48691331601c5027580ae5af5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c9f6aa71e71ab2513c8b708a5c8313ba recordList, Func<RC_7fd286c48691331601c5027580ae5af5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c9f6aa71e71ab2513c8b708a5c8313ba(RC_7fd286c48691331601c5027580ae5af5[] array) {
  RL_c9f6aa71e71ab2513c8b708a5c8313ba result = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
result.InnerFromArray(array);
    return result;
}

public static RL_c9f6aa71e71ab2513c8b708a5c8313ba ToList<T>(T[] array, Func <T, RC_7fd286c48691331601c5027580ae5af5> converter) {
  RL_c9f6aa71e71ab2513c8b708a5c8313ba result = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c9f6aa71e71ab2513c8b708a5c8313ba FromRestList<T>(RestList<T> restList, Func <T, RC_7fd286c48691331601c5027580ae5af5> converter) {
  RL_c9f6aa71e71ab2513c8b708a5c8313ba result = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c9f6aa71e71ab2513c8b708a5c8313ba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(15,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7fd286c48691331601c5027580ae5af5> NewList() {
return new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
}


} // RL_c9f6aa71e71ab2513c8b708a5c8313ba
}

