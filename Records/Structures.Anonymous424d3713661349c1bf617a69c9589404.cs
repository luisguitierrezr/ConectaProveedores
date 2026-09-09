namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EzdNQhNmwUm_YXppyViUBA)
///  <code>RC_a8c9db0520f3bc88b53a407e39ea6fe5</code> that represents <code>FolioFileRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioFileRecord
public partial struct RC_a8c9db0520f3bc88b53a407e39ea6fe5 : ITypedRecord<RC_a8c9db0520f3bc88b53a407e39ea6fe5> {
internal static readonly GlobalObjectKey IdFolioFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BdvJqPMgiLy1OkB+Oepv5Q");

public ST_a23a10e9592e51ca9ffbbbc42c558496Structure ssSTFolioFile;


public static implicit operator ST_a23a10e9592e51ca9ffbbbc42c558496Structure( RC_a8c9db0520f3bc88b53a407e39ea6fe5 r) {
return r.ssSTFolioFile;
}

public static implicit operator RC_a8c9db0520f3bc88b53a407e39ea6fe5 (ST_a23a10e9592e51ca9ffbbbc42c558496Structure r) {
RC_a8c9db0520f3bc88b53a407e39ea6fe5 res = new RC_a8c9db0520f3bc88b53a407e39ea6fe5 ();
res.ssSTFolioFile = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a8c9db0520f3bc88b53a407e39ea6fe5() {
OptimizedAttributes = null;
ssSTFolioFile = new ST_a23a10e9592e51ca9ffbbbc42c558496Structure();
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
    ssSTFolioFile.OptimizedAttributes = value[0];
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
ssSTFolioFile.Read( r, ref index);
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
public void ReadIM(RC_a8c9db0520f3bc88b53a407e39ea6fe5 r) {
this = r;
}


public static bool operator == (RC_a8c9db0520f3bc88b53a407e39ea6fe5 a, RC_a8c9db0520f3bc88b53a407e39ea6fe5 b) {
if (a.ssSTFolioFile != b.ssSTFolioFile) return false;
return true;
}

public static bool operator != (RC_a8c9db0520f3bc88b53a407e39ea6fe5 a, RC_a8c9db0520f3bc88b53a407e39ea6fe5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a8c9db0520f3bc88b53a407e39ea6fe5)) return false;
return (this == (RC_a8c9db0520f3bc88b53a407e39ea6fe5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioFile.InternalRecursiveSave();
}


public RC_a8c9db0520f3bc88b53a407e39ea6fe5 Duplicate() {
RC_a8c9db0520f3bc88b53a407e39ea6fe5 t;
t.ssSTFolioFile = (ST_a23a10e9592e51ca9ffbbbc42c558496Structure)this.ssSTFolioFile.Duplicate();
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
if (head == "foliofile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioFile")) variable.Value = ssSTFolioFile; else variable.Optimized = true;
variable.SetFieldName("foliofile");
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
if (key == IdFolioFile) {
return ssSTFolioFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioFile.Key.AsGuid) {
return ssSTFolioFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioFile.FillFromOther((IRecord) other.AttributeGet(IdFolioFile));
}
} // RC_a8c9db0520f3bc88b53a407e39ea6fe5
/// <summary>
/// RecordList type <code>FolioFileRecordList</code> that represents a record list of
///  <code>FolioFile</code>
/// </summary>
public partial class RL_96e940436b36b2a77c224586973d50d6 : GenericRecordList<RC_a8c9db0520f3bc88b53a407e39ea6fe5>, IEnumerable, IEnumerator {

protected override RC_a8c9db0520f3bc88b53a407e39ea6fe5 GetElementDefaultValue() {
return new RC_a8c9db0520f3bc88b53a407e39ea6fe5();
}

public T[] ToArray<T>(Func<RC_a8c9db0520f3bc88b53a407e39ea6fe5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_96e940436b36b2a77c224586973d50d6 recordList, Func<RC_a8c9db0520f3bc88b53a407e39ea6fe5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_96e940436b36b2a77c224586973d50d6(RC_a8c9db0520f3bc88b53a407e39ea6fe5[] array) {
  RL_96e940436b36b2a77c224586973d50d6 result = new RL_96e940436b36b2a77c224586973d50d6();
result.InnerFromArray(array);
    return result;
}

public static RL_96e940436b36b2a77c224586973d50d6 ToList<T>(T[] array, Func <T, RC_a8c9db0520f3bc88b53a407e39ea6fe5> converter) {
  RL_96e940436b36b2a77c224586973d50d6 result = new RL_96e940436b36b2a77c224586973d50d6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_96e940436b36b2a77c224586973d50d6 FromRestList<T>(RestList<T> restList, Func <T, RC_a8c9db0520f3bc88b53a407e39ea6fe5> converter) {
  RL_96e940436b36b2a77c224586973d50d6 result = new RL_96e940436b36b2a77c224586973d50d6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_96e940436b36b2a77c224586973d50d6() : base() {
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
protected override OSList<RC_a8c9db0520f3bc88b53a407e39ea6fe5> NewList() {
return new RL_96e940436b36b2a77c224586973d50d6();
}


} // RL_96e940436b36b2a77c224586973d50d6
}

