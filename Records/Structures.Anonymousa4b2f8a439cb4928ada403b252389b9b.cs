namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pPiypMs5KEmtpAOyUjibmw)
///  <code>RC_d4c9aad369e5098dd6cf11900712043f</code> that represent
/// s <code>FolioScreenTableStructureRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioScreenTableStructureRecord
public partial struct RC_d4c9aad369e5098dd6cf11900712043f : ITypedRecord<RC_d4c9aad369e5098dd6cf11900712043f> {
internal static readonly GlobalObjectKey IdFolioScreenTableStructure = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*06rJ1OVpjQnWzxGQBxIEPw");

public ST_3dc7a528e6a1e146b195db5c3edb006aStructure ssSTFolioScreenTableStructure;


public static implicit operator ST_3dc7a528e6a1e146b195db5c3edb006aStructure( RC_d4c9aad369e5098dd6cf11900712043f r) {
return r.ssSTFolioScreenTableStructure;
}

public static implicit operator RC_d4c9aad369e5098dd6cf11900712043f (ST_3dc7a528e6a1e146b195db5c3edb006aStructure r) {
RC_d4c9aad369e5098dd6cf11900712043f res = new RC_d4c9aad369e5098dd6cf11900712043f ();
res.ssSTFolioScreenTableStructure = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d4c9aad369e5098dd6cf11900712043f() {
OptimizedAttributes = null;
ssSTFolioScreenTableStructure = new ST_3dc7a528e6a1e146b195db5c3edb006aStructure();
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
    ssSTFolioScreenTableStructure.OptimizedAttributes = value[0];
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
ssSTFolioScreenTableStructure.Read( r, ref index);
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
public void ReadIM(RC_d4c9aad369e5098dd6cf11900712043f r) {
this = r;
}


public static bool operator == (RC_d4c9aad369e5098dd6cf11900712043f a, RC_d4c9aad369e5098dd6cf11900712043f b) {
if (a.ssSTFolioScreenTableStructure != b.ssSTFolioScreenTableStructure) return false;
return true;
}

public static bool operator != (RC_d4c9aad369e5098dd6cf11900712043f a, RC_d4c9aad369e5098dd6cf11900712043f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d4c9aad369e5098dd6cf11900712043f)) return false;
return (this == (RC_d4c9aad369e5098dd6cf11900712043f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioScreenTableStructure.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioScreenTableStructure.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioScreenTableStructure.InternalRecursiveSave();
}


public RC_d4c9aad369e5098dd6cf11900712043f Duplicate() {
RC_d4c9aad369e5098dd6cf11900712043f t;
t.ssSTFolioScreenTableStructure = (ST_3dc7a528e6a1e146b195db5c3edb006aStructure)this.ssSTFolioScreenTableStructure.Duplicate();
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
if (head == "folioscreentablestructure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioScreenTableStructure")) variable.Value = ssSTFolioScreenTableStructure; else variable.Optimized = true;
variable.SetFieldName("folioscreentablestructure");
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
if (key == IdFolioScreenTableStructure) {
return ssSTFolioScreenTableStructure;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioScreenTableStructure.Key.AsGuid) {
return ssSTFolioScreenTableStructure;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioScreenTableStructure.FillFromOther((IRecord) other.AttributeGet(IdFolioScreenTableStructure));
}
} // RC_d4c9aad369e5098dd6cf11900712043f
/// <summary>
/// RecordList type <code>FolioScreenTableStructureRecordList</code> that represents a record list of
///  <code>FolioScreenTableStructure</code>
/// </summary>
public partial class RL_204d27f15df51696aa2d01346afb752d : GenericRecordList<RC_d4c9aad369e5098dd6cf11900712043f>, IEnumerable, IEnumerator {

protected override RC_d4c9aad369e5098dd6cf11900712043f GetElementDefaultValue() {
return new RC_d4c9aad369e5098dd6cf11900712043f();
}

public T[] ToArray<T>(Func<RC_d4c9aad369e5098dd6cf11900712043f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_204d27f15df51696aa2d01346afb752d recordList, Func<RC_d4c9aad369e5098dd6cf11900712043f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_204d27f15df51696aa2d01346afb752d(RC_d4c9aad369e5098dd6cf11900712043f[] array) {
  RL_204d27f15df51696aa2d01346afb752d result = new RL_204d27f15df51696aa2d01346afb752d();
result.InnerFromArray(array);
    return result;
}

public static RL_204d27f15df51696aa2d01346afb752d ToList<T>(T[] array, Func <T, RC_d4c9aad369e5098dd6cf11900712043f> converter) {
  RL_204d27f15df51696aa2d01346afb752d result = new RL_204d27f15df51696aa2d01346afb752d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_204d27f15df51696aa2d01346afb752d FromRestList<T>(RestList<T> restList, Func <T, RC_d4c9aad369e5098dd6cf11900712043f> converter) {
  RL_204d27f15df51696aa2d01346afb752d result = new RL_204d27f15df51696aa2d01346afb752d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_204d27f15df51696aa2d01346afb752d() : base() {
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
protected override OSList<RC_d4c9aad369e5098dd6cf11900712043f> NewList() {
return new RL_204d27f15df51696aa2d01346afb752d();
}


} // RL_204d27f15df51696aa2d01346afb752d
}

