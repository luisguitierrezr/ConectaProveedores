namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (qpCWtFXE80qv7lWCgUljpw)
///  <code>RC_809967b191c14af33407e7f12d25eb73</code> that represents <code>FolioStructRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioStructRecord
public partial struct RC_809967b191c14af33407e7f12d25eb73 : ITypedRecord<RC_809967b191c14af33407e7f12d25eb73> {
internal static readonly GlobalObjectKey IdFolioStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sWeZgMGR80o0B+fxLSXrcw");

public ST_aa3e6001f162e602247a2e2cc13e2cf8Structure ssSTFolioStruct;


public static implicit operator ST_aa3e6001f162e602247a2e2cc13e2cf8Structure( RC_809967b191c14af33407e7f12d25eb73 r) {
return r.ssSTFolioStruct;
}

public static implicit operator RC_809967b191c14af33407e7f12d25eb73 (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure r) {
RC_809967b191c14af33407e7f12d25eb73 res = new RC_809967b191c14af33407e7f12d25eb73 ();
res.ssSTFolioStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_809967b191c14af33407e7f12d25eb73() {
OptimizedAttributes = null;
ssSTFolioStruct = new ST_aa3e6001f162e602247a2e2cc13e2cf8Structure();
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
    ssSTFolioStruct.OptimizedAttributes = value[0];
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
ssSTFolioStruct.Read( r, ref index);
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
public void ReadIM(RC_809967b191c14af33407e7f12d25eb73 r) {
this = r;
}


public static bool operator == (RC_809967b191c14af33407e7f12d25eb73 a, RC_809967b191c14af33407e7f12d25eb73 b) {
if (a.ssSTFolioStruct != b.ssSTFolioStruct) return false;
return true;
}

public static bool operator != (RC_809967b191c14af33407e7f12d25eb73 a, RC_809967b191c14af33407e7f12d25eb73 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_809967b191c14af33407e7f12d25eb73)) return false;
return (this == (RC_809967b191c14af33407e7f12d25eb73)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioStruct.InternalRecursiveSave();
}


public RC_809967b191c14af33407e7f12d25eb73 Duplicate() {
RC_809967b191c14af33407e7f12d25eb73 t;
t.ssSTFolioStruct = (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure)this.ssSTFolioStruct.Duplicate();
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
if (head == "foliostruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStruct")) variable.Value = ssSTFolioStruct; else variable.Optimized = true;
variable.SetFieldName("foliostruct");
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
if (key == IdFolioStruct) {
return ssSTFolioStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioStruct.Key.AsGuid) {
return ssSTFolioStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioStruct.FillFromOther((IRecord) other.AttributeGet(IdFolioStruct));
}
} // RC_809967b191c14af33407e7f12d25eb73
/// <summary>
/// RecordList type <code>FolioStructRecordList</code> that represents a record list of
///  <code>FolioStruct</code>
/// </summary>
public partial class RL_b61ce6f1fecbe16390f9c082ba3e1cb9 : GenericRecordList<RC_809967b191c14af33407e7f12d25eb73>, IEnumerable, IEnumerator {

protected override RC_809967b191c14af33407e7f12d25eb73 GetElementDefaultValue() {
return new RC_809967b191c14af33407e7f12d25eb73();
}

public T[] ToArray<T>(Func<RC_809967b191c14af33407e7f12d25eb73, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b61ce6f1fecbe16390f9c082ba3e1cb9 recordList, Func<RC_809967b191c14af33407e7f12d25eb73, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b61ce6f1fecbe16390f9c082ba3e1cb9(RC_809967b191c14af33407e7f12d25eb73[] array) {
  RL_b61ce6f1fecbe16390f9c082ba3e1cb9 result = new RL_b61ce6f1fecbe16390f9c082ba3e1cb9();
result.InnerFromArray(array);
    return result;
}

public static RL_b61ce6f1fecbe16390f9c082ba3e1cb9 ToList<T>(T[] array, Func <T, RC_809967b191c14af33407e7f12d25eb73> converter) {
  RL_b61ce6f1fecbe16390f9c082ba3e1cb9 result = new RL_b61ce6f1fecbe16390f9c082ba3e1cb9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b61ce6f1fecbe16390f9c082ba3e1cb9 FromRestList<T>(RestList<T> restList, Func <T, RC_809967b191c14af33407e7f12d25eb73> converter) {
  RL_b61ce6f1fecbe16390f9c082ba3e1cb9 result = new RL_b61ce6f1fecbe16390f9c082ba3e1cb9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b61ce6f1fecbe16390f9c082ba3e1cb9() : base() {
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
protected override OSList<RC_809967b191c14af33407e7f12d25eb73> NewList() {
return new RL_b61ce6f1fecbe16390f9c082ba3e1cb9();
}


} // RL_b61ce6f1fecbe16390f9c082ba3e1cb9
}

