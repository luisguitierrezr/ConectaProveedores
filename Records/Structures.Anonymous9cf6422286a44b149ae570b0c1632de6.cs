namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IkL2nKSGFEua5XCwwWMt5g)
///  <code>RC_70b13e28c6212feb2e7d4ad3155dda34</code> that represents <code>FolioQFilesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioQFilesRecord
public partial struct RC_70b13e28c6212feb2e7d4ad3155dda34 : ITypedRecord<RC_70b13e28c6212feb2e7d4ad3155dda34> {
internal static readonly GlobalObjectKey IdFolioQFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KD6xcCHG6y8ufUrTFV3aNA");

public ST_b9bc0a93e29018653085b5de5dd1951eStructure ssSTFolioQFiles;


public static implicit operator ST_b9bc0a93e29018653085b5de5dd1951eStructure( RC_70b13e28c6212feb2e7d4ad3155dda34 r) {
return r.ssSTFolioQFiles;
}

public static implicit operator RC_70b13e28c6212feb2e7d4ad3155dda34 (ST_b9bc0a93e29018653085b5de5dd1951eStructure r) {
RC_70b13e28c6212feb2e7d4ad3155dda34 res = new RC_70b13e28c6212feb2e7d4ad3155dda34 ();
res.ssSTFolioQFiles = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_70b13e28c6212feb2e7d4ad3155dda34() {
OptimizedAttributes = null;
ssSTFolioQFiles = new ST_b9bc0a93e29018653085b5de5dd1951eStructure();
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
    ssSTFolioQFiles.OptimizedAttributes = value[0];
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
ssSTFolioQFiles.Read( r, ref index);
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
public void ReadIM(RC_70b13e28c6212feb2e7d4ad3155dda34 r) {
this = r;
}


public static bool operator == (RC_70b13e28c6212feb2e7d4ad3155dda34 a, RC_70b13e28c6212feb2e7d4ad3155dda34 b) {
if (a.ssSTFolioQFiles != b.ssSTFolioQFiles) return false;
return true;
}

public static bool operator != (RC_70b13e28c6212feb2e7d4ad3155dda34 a, RC_70b13e28c6212feb2e7d4ad3155dda34 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_70b13e28c6212feb2e7d4ad3155dda34)) return false;
return (this == (RC_70b13e28c6212feb2e7d4ad3155dda34)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioQFiles.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioQFiles.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioQFiles.InternalRecursiveSave();
}


public RC_70b13e28c6212feb2e7d4ad3155dda34 Duplicate() {
RC_70b13e28c6212feb2e7d4ad3155dda34 t;
t.ssSTFolioQFiles = (ST_b9bc0a93e29018653085b5de5dd1951eStructure)this.ssSTFolioQFiles.Duplicate();
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
if (head == "folioqfiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioQFiles")) variable.Value = ssSTFolioQFiles; else variable.Optimized = true;
variable.SetFieldName("folioqfiles");
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
if (key == IdFolioQFiles) {
return ssSTFolioQFiles;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioQFiles.Key.AsGuid) {
return ssSTFolioQFiles;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioQFiles.FillFromOther((IRecord) other.AttributeGet(IdFolioQFiles));
}
} // RC_70b13e28c6212feb2e7d4ad3155dda34
/// <summary>
/// RecordList type <code>FolioQFilesRecordList</code> that represents a record list of
///  <code>FolioQFiles</code>
/// </summary>
public partial class RL_21a67a00d4847827122758449156598b : GenericRecordList<RC_70b13e28c6212feb2e7d4ad3155dda34>, IEnumerable, IEnumerator {

protected override RC_70b13e28c6212feb2e7d4ad3155dda34 GetElementDefaultValue() {
return new RC_70b13e28c6212feb2e7d4ad3155dda34();
}

public T[] ToArray<T>(Func<RC_70b13e28c6212feb2e7d4ad3155dda34, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_21a67a00d4847827122758449156598b recordList, Func<RC_70b13e28c6212feb2e7d4ad3155dda34, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_21a67a00d4847827122758449156598b(RC_70b13e28c6212feb2e7d4ad3155dda34[] array) {
  RL_21a67a00d4847827122758449156598b result = new RL_21a67a00d4847827122758449156598b();
result.InnerFromArray(array);
    return result;
}

public static RL_21a67a00d4847827122758449156598b ToList<T>(T[] array, Func <T, RC_70b13e28c6212feb2e7d4ad3155dda34> converter) {
  RL_21a67a00d4847827122758449156598b result = new RL_21a67a00d4847827122758449156598b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_21a67a00d4847827122758449156598b FromRestList<T>(RestList<T> restList, Func <T, RC_70b13e28c6212feb2e7d4ad3155dda34> converter) {
  RL_21a67a00d4847827122758449156598b result = new RL_21a67a00d4847827122758449156598b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_21a67a00d4847827122758449156598b() : base() {
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
protected override OSList<RC_70b13e28c6212feb2e7d4ad3155dda34> NewList() {
return new RL_21a67a00d4847827122758449156598b();
}


} // RL_21a67a00d4847827122758449156598b
}

