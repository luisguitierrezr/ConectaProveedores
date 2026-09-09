namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Rqhq0fNs6EOuXduZHv2vkA)
///  <code>RC_4d24471d0d73e8226f7ca6dd09937c26</code> that represents <code>FilesJsonRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FilesJsonRecord
public partial struct RC_4d24471d0d73e8226f7ca6dd09937c26 : ITypedRecord<RC_4d24471d0d73e8226f7ca6dd09937c26> {
internal static readonly GlobalObjectKey IdFilesJson = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HUckTXMNIuhvfKbdCZN8Jg");

public ST_6c0a0d3b1d72414f90bb9301bad200fbStructure ssSTFilesJson;


public static implicit operator ST_6c0a0d3b1d72414f90bb9301bad200fbStructure( RC_4d24471d0d73e8226f7ca6dd09937c26 r) {
return r.ssSTFilesJson;
}

public static implicit operator RC_4d24471d0d73e8226f7ca6dd09937c26 (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure r) {
RC_4d24471d0d73e8226f7ca6dd09937c26 res = new RC_4d24471d0d73e8226f7ca6dd09937c26 ();
res.ssSTFilesJson = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4d24471d0d73e8226f7ca6dd09937c26() {
OptimizedAttributes = null;
ssSTFilesJson = new ST_6c0a0d3b1d72414f90bb9301bad200fbStructure();
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
    ssSTFilesJson.OptimizedAttributes = value[0];
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
ssSTFilesJson.Read( r, ref index);
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
public void ReadIM(RC_4d24471d0d73e8226f7ca6dd09937c26 r) {
this = r;
}


public static bool operator == (RC_4d24471d0d73e8226f7ca6dd09937c26 a, RC_4d24471d0d73e8226f7ca6dd09937c26 b) {
if (a.ssSTFilesJson != b.ssSTFilesJson) return false;
return true;
}

public static bool operator != (RC_4d24471d0d73e8226f7ca6dd09937c26 a, RC_4d24471d0d73e8226f7ca6dd09937c26 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4d24471d0d73e8226f7ca6dd09937c26)) return false;
return (this == (RC_4d24471d0d73e8226f7ca6dd09937c26)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFilesJson.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFilesJson.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFilesJson.InternalRecursiveSave();
}


public RC_4d24471d0d73e8226f7ca6dd09937c26 Duplicate() {
RC_4d24471d0d73e8226f7ca6dd09937c26 t;
t.ssSTFilesJson = (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure)this.ssSTFilesJson.Duplicate();
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
if (head == "filesjson") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FilesJson")) variable.Value = ssSTFilesJson; else variable.Optimized = true;
variable.SetFieldName("filesjson");
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
if (key == IdFilesJson) {
return ssSTFilesJson;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFilesJson.Key.AsGuid) {
return ssSTFilesJson;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFilesJson.FillFromOther((IRecord) other.AttributeGet(IdFilesJson));
}
} // RC_4d24471d0d73e8226f7ca6dd09937c26
/// <summary>
/// RecordList type <code>FilesJsonRecordList</code> that represents a record list of
///  <code>FilesJson</code>
/// </summary>
public partial class RL_8ef8aa511f6bdcfc4b07cd6663af43ad : GenericRecordList<RC_4d24471d0d73e8226f7ca6dd09937c26>, IEnumerable, IEnumerator {

protected override RC_4d24471d0d73e8226f7ca6dd09937c26 GetElementDefaultValue() {
return new RC_4d24471d0d73e8226f7ca6dd09937c26();
}

public T[] ToArray<T>(Func<RC_4d24471d0d73e8226f7ca6dd09937c26, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8ef8aa511f6bdcfc4b07cd6663af43ad recordList, Func<RC_4d24471d0d73e8226f7ca6dd09937c26, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8ef8aa511f6bdcfc4b07cd6663af43ad(RC_4d24471d0d73e8226f7ca6dd09937c26[] array) {
  RL_8ef8aa511f6bdcfc4b07cd6663af43ad result = new RL_8ef8aa511f6bdcfc4b07cd6663af43ad();
result.InnerFromArray(array);
    return result;
}

public static RL_8ef8aa511f6bdcfc4b07cd6663af43ad ToList<T>(T[] array, Func <T, RC_4d24471d0d73e8226f7ca6dd09937c26> converter) {
  RL_8ef8aa511f6bdcfc4b07cd6663af43ad result = new RL_8ef8aa511f6bdcfc4b07cd6663af43ad();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8ef8aa511f6bdcfc4b07cd6663af43ad FromRestList<T>(RestList<T> restList, Func <T, RC_4d24471d0d73e8226f7ca6dd09937c26> converter) {
  RL_8ef8aa511f6bdcfc4b07cd6663af43ad result = new RL_8ef8aa511f6bdcfc4b07cd6663af43ad();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8ef8aa511f6bdcfc4b07cd6663af43ad() : base() {
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
protected override OSList<RC_4d24471d0d73e8226f7ca6dd09937c26> NewList() {
return new RL_8ef8aa511f6bdcfc4b07cd6663af43ad();
}


} // RL_8ef8aa511f6bdcfc4b07cd6663af43ad
}

