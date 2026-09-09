namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+qF9ElR0wkmouWil8BypGQ)
///  <code>RC_dac4d0b34831478d401f08fdebfad1b4</code> that represent
/// s <code>DocumentExtrationFilesRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationFilesRecord
public partial struct RC_dac4d0b34831478d401f08fdebfad1b4 : ITypedRecord<RC_dac4d0b34831478d401f08fdebfad1b4> {
internal static readonly GlobalObjectKey IdDocumentExtrationFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*s9DE2jFIjUdAHwj96_rRtA");

public ST_27be19a2068bdbf4844f837df703a71bStructure ssSTDocumentExtrationFiles;


public static implicit operator ST_27be19a2068bdbf4844f837df703a71bStructure( RC_dac4d0b34831478d401f08fdebfad1b4 r) {
return r.ssSTDocumentExtrationFiles;
}

public static implicit operator RC_dac4d0b34831478d401f08fdebfad1b4 (ST_27be19a2068bdbf4844f837df703a71bStructure r) {
RC_dac4d0b34831478d401f08fdebfad1b4 res = new RC_dac4d0b34831478d401f08fdebfad1b4 ();
res.ssSTDocumentExtrationFiles = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dac4d0b34831478d401f08fdebfad1b4() {
OptimizedAttributes = null;
ssSTDocumentExtrationFiles = new ST_27be19a2068bdbf4844f837df703a71bStructure();
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
    ssSTDocumentExtrationFiles.OptimizedAttributes = value[0];
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
ssSTDocumentExtrationFiles.Read( r, ref index);
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
public void ReadIM(RC_dac4d0b34831478d401f08fdebfad1b4 r) {
this = r;
}


public static bool operator == (RC_dac4d0b34831478d401f08fdebfad1b4 a, RC_dac4d0b34831478d401f08fdebfad1b4 b) {
if (a.ssSTDocumentExtrationFiles != b.ssSTDocumentExtrationFiles) return false;
return true;
}

public static bool operator != (RC_dac4d0b34831478d401f08fdebfad1b4 a, RC_dac4d0b34831478d401f08fdebfad1b4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dac4d0b34831478d401f08fdebfad1b4)) return false;
return (this == (RC_dac4d0b34831478d401f08fdebfad1b4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationFiles.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationFiles.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationFiles.InternalRecursiveSave();
}


public RC_dac4d0b34831478d401f08fdebfad1b4 Duplicate() {
RC_dac4d0b34831478d401f08fdebfad1b4 t;
t.ssSTDocumentExtrationFiles = (ST_27be19a2068bdbf4844f837df703a71bStructure)this.ssSTDocumentExtrationFiles.Duplicate();
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
if (head == "documentextrationfiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationFiles")) variable.Value = ssSTDocumentExtrationFiles; else variable.Optimized = true;
variable.SetFieldName("documentextrationfiles");
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
if (key == IdDocumentExtrationFiles) {
return ssSTDocumentExtrationFiles;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationFiles.Key.AsGuid) {
return ssSTDocumentExtrationFiles;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationFiles.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationFiles));
}
} // RC_dac4d0b34831478d401f08fdebfad1b4
/// <summary>
/// RecordList type <code>DocumentExtrationFilesRecordList</code> that represents a record list of
///  <code>DocumentExtrationFiles</code>
/// </summary>
public partial class RL_953ccd44e2254d2ff6194b7185f90f7b : GenericRecordList<RC_dac4d0b34831478d401f08fdebfad1b4>, IEnumerable, IEnumerator {

protected override RC_dac4d0b34831478d401f08fdebfad1b4 GetElementDefaultValue() {
return new RC_dac4d0b34831478d401f08fdebfad1b4();
}

public T[] ToArray<T>(Func<RC_dac4d0b34831478d401f08fdebfad1b4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_953ccd44e2254d2ff6194b7185f90f7b recordList, Func<RC_dac4d0b34831478d401f08fdebfad1b4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_953ccd44e2254d2ff6194b7185f90f7b(RC_dac4d0b34831478d401f08fdebfad1b4[] array) {
  RL_953ccd44e2254d2ff6194b7185f90f7b result = new RL_953ccd44e2254d2ff6194b7185f90f7b();
result.InnerFromArray(array);
    return result;
}

public static RL_953ccd44e2254d2ff6194b7185f90f7b ToList<T>(T[] array, Func <T, RC_dac4d0b34831478d401f08fdebfad1b4> converter) {
  RL_953ccd44e2254d2ff6194b7185f90f7b result = new RL_953ccd44e2254d2ff6194b7185f90f7b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_953ccd44e2254d2ff6194b7185f90f7b FromRestList<T>(RestList<T> restList, Func <T, RC_dac4d0b34831478d401f08fdebfad1b4> converter) {
  RL_953ccd44e2254d2ff6194b7185f90f7b result = new RL_953ccd44e2254d2ff6194b7185f90f7b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_953ccd44e2254d2ff6194b7185f90f7b() : base() {
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
protected override OSList<RC_dac4d0b34831478d401f08fdebfad1b4> NewList() {
return new RL_953ccd44e2254d2ff6194b7185f90f7b();
}


} // RL_953ccd44e2254d2ff6194b7185f90f7b
}

