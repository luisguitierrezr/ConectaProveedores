namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (333Es6CKZUqsCZWiadZxfQ)
///  <code>RC_11133d573140bca413fb3e86df694e32</code> that represents <code>FolioQImportRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioQImportRecord
public partial struct RC_11133d573140bca413fb3e86df694e32 : ITypedRecord<RC_11133d573140bca413fb3e86df694e32> {
internal static readonly GlobalObjectKey IdFolioQImport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Vz0TEUAxpLwT+z6G32lOMg");

public ST_9d31438c744477d5e7fa3ba41ac26dffStructure ssSTFolioQImport;


public static implicit operator ST_9d31438c744477d5e7fa3ba41ac26dffStructure( RC_11133d573140bca413fb3e86df694e32 r) {
return r.ssSTFolioQImport;
}

public static implicit operator RC_11133d573140bca413fb3e86df694e32 (ST_9d31438c744477d5e7fa3ba41ac26dffStructure r) {
RC_11133d573140bca413fb3e86df694e32 res = new RC_11133d573140bca413fb3e86df694e32 ();
res.ssSTFolioQImport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_11133d573140bca413fb3e86df694e32() {
OptimizedAttributes = null;
ssSTFolioQImport = new ST_9d31438c744477d5e7fa3ba41ac26dffStructure();
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
    ssSTFolioQImport.OptimizedAttributes = value[0];
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
ssSTFolioQImport.Read( r, ref index);
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
public void ReadIM(RC_11133d573140bca413fb3e86df694e32 r) {
this = r;
}


public static bool operator == (RC_11133d573140bca413fb3e86df694e32 a, RC_11133d573140bca413fb3e86df694e32 b) {
if (a.ssSTFolioQImport != b.ssSTFolioQImport) return false;
return true;
}

public static bool operator != (RC_11133d573140bca413fb3e86df694e32 a, RC_11133d573140bca413fb3e86df694e32 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_11133d573140bca413fb3e86df694e32)) return false;
return (this == (RC_11133d573140bca413fb3e86df694e32)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioQImport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioQImport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioQImport.InternalRecursiveSave();
}


public RC_11133d573140bca413fb3e86df694e32 Duplicate() {
RC_11133d573140bca413fb3e86df694e32 t;
t.ssSTFolioQImport = (ST_9d31438c744477d5e7fa3ba41ac26dffStructure)this.ssSTFolioQImport.Duplicate();
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
if (head == "folioqimport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioQImport")) variable.Value = ssSTFolioQImport; else variable.Optimized = true;
variable.SetFieldName("folioqimport");
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
if (key == IdFolioQImport) {
return ssSTFolioQImport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioQImport.Key.AsGuid) {
return ssSTFolioQImport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioQImport.FillFromOther((IRecord) other.AttributeGet(IdFolioQImport));
}
} // RC_11133d573140bca413fb3e86df694e32
/// <summary>
/// RecordList type <code>FolioQImportRecordList</code> that represents a record list of
///  <code>FolioQImport</code>
/// </summary>
public partial class RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 : GenericRecordList<RC_11133d573140bca413fb3e86df694e32>, IEnumerable, IEnumerator {

protected override RC_11133d573140bca413fb3e86df694e32 GetElementDefaultValue() {
return new RC_11133d573140bca413fb3e86df694e32();
}

public T[] ToArray<T>(Func<RC_11133d573140bca413fb3e86df694e32, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 recordList, Func<RC_11133d573140bca413fb3e86df694e32, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_15a59605b8f7d8d15b1b6b6cad6ee0c8(RC_11133d573140bca413fb3e86df694e32[] array) {
  RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 result = new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();
result.InnerFromArray(array);
    return result;
}

public static RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 ToList<T>(T[] array, Func <T, RC_11133d573140bca413fb3e86df694e32> converter) {
  RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 result = new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 FromRestList<T>(RestList<T> restList, Func <T, RC_11133d573140bca413fb3e86df694e32> converter) {
  RL_15a59605b8f7d8d15b1b6b6cad6ee0c8 result = new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_15a59605b8f7d8d15b1b6b6cad6ee0c8() : base() {
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
protected override OSList<RC_11133d573140bca413fb3e86df694e32> NewList() {
return new RL_15a59605b8f7d8d15b1b6b6cad6ee0c8();
}


} // RL_15a59605b8f7d8d15b1b6b6cad6ee0c8
}

