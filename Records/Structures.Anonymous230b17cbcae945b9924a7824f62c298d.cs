namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yxcLI+nKuUWSSngk9iwpjQ)
///  <code>RC_8ffee1344334d078ce2df096169df2fe</code> that represent
/// s <code>DocumentExtrationUUIDRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationUUIDRecord
public partial struct RC_8ffee1344334d078ce2df096169df2fe : ITypedRecord<RC_8ffee1344334d078ce2df096169df2fe> {
internal static readonly GlobalObjectKey IdDocumentExtrationUUID = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NOH+jzRDeNDOLfCWFp3y_g");

public ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure ssSTDocumentExtrationUUID;


public static implicit operator ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure( RC_8ffee1344334d078ce2df096169df2fe r) {
return r.ssSTDocumentExtrationUUID;
}

public static implicit operator RC_8ffee1344334d078ce2df096169df2fe (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure r) {
RC_8ffee1344334d078ce2df096169df2fe res = new RC_8ffee1344334d078ce2df096169df2fe ();
res.ssSTDocumentExtrationUUID = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8ffee1344334d078ce2df096169df2fe() {
OptimizedAttributes = null;
ssSTDocumentExtrationUUID = new ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure();
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
    ssSTDocumentExtrationUUID.OptimizedAttributes = value[0];
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
ssSTDocumentExtrationUUID.Read( r, ref index);
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
public void ReadIM(RC_8ffee1344334d078ce2df096169df2fe r) {
this = r;
}


public static bool operator == (RC_8ffee1344334d078ce2df096169df2fe a, RC_8ffee1344334d078ce2df096169df2fe b) {
if (a.ssSTDocumentExtrationUUID != b.ssSTDocumentExtrationUUID) return false;
return true;
}

public static bool operator != (RC_8ffee1344334d078ce2df096169df2fe a, RC_8ffee1344334d078ce2df096169df2fe b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8ffee1344334d078ce2df096169df2fe)) return false;
return (this == (RC_8ffee1344334d078ce2df096169df2fe)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationUUID.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationUUID.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationUUID.InternalRecursiveSave();
}


public RC_8ffee1344334d078ce2df096169df2fe Duplicate() {
RC_8ffee1344334d078ce2df096169df2fe t;
t.ssSTDocumentExtrationUUID = (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure)this.ssSTDocumentExtrationUUID.Duplicate();
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
if (head == "documentextrationuuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationUUID")) variable.Value = ssSTDocumentExtrationUUID; else variable.Optimized = true;
variable.SetFieldName("documentextrationuuid");
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
if (key == IdDocumentExtrationUUID) {
return ssSTDocumentExtrationUUID;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationUUID.Key.AsGuid) {
return ssSTDocumentExtrationUUID;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationUUID.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationUUID));
}
} // RC_8ffee1344334d078ce2df096169df2fe
/// <summary>
/// RecordList type <code>DocumentExtrationUUIDRecordList</code> that represents a record list of
///  <code>DocumentExtrationUUID</code>
/// </summary>
public partial class RL_88c9a54f808c1640f67cb9d9832d39d3 : GenericRecordList<RC_8ffee1344334d078ce2df096169df2fe>, IEnumerable, IEnumerator {

protected override RC_8ffee1344334d078ce2df096169df2fe GetElementDefaultValue() {
return new RC_8ffee1344334d078ce2df096169df2fe();
}

public T[] ToArray<T>(Func<RC_8ffee1344334d078ce2df096169df2fe, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_88c9a54f808c1640f67cb9d9832d39d3 recordList, Func<RC_8ffee1344334d078ce2df096169df2fe, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_88c9a54f808c1640f67cb9d9832d39d3(RC_8ffee1344334d078ce2df096169df2fe[] array) {
  RL_88c9a54f808c1640f67cb9d9832d39d3 result = new RL_88c9a54f808c1640f67cb9d9832d39d3();
result.InnerFromArray(array);
    return result;
}

public static RL_88c9a54f808c1640f67cb9d9832d39d3 ToList<T>(T[] array, Func <T, RC_8ffee1344334d078ce2df096169df2fe> converter) {
  RL_88c9a54f808c1640f67cb9d9832d39d3 result = new RL_88c9a54f808c1640f67cb9d9832d39d3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_88c9a54f808c1640f67cb9d9832d39d3 FromRestList<T>(RestList<T> restList, Func <T, RC_8ffee1344334d078ce2df096169df2fe> converter) {
  RL_88c9a54f808c1640f67cb9d9832d39d3 result = new RL_88c9a54f808c1640f67cb9d9832d39d3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_88c9a54f808c1640f67cb9d9832d39d3() : base() {
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
protected override OSList<RC_8ffee1344334d078ce2df096169df2fe> NewList() {
return new RL_88c9a54f808c1640f67cb9d9832d39d3();
}


} // RL_88c9a54f808c1640f67cb9d9832d39d3
}

