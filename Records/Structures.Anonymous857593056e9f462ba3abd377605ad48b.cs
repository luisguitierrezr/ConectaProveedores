namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BZN1hZ9uK0ajq9N3YFrUiw)
///  <code>RC_9983883fbc26c5bf3e842f01355fd0c8</code> that represent
/// s <code>FormFormApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: FormFormApprovalLevelRecord
public partial struct RC_9983883fbc26c5bf3e842f01355fd0c8 : ITypedRecord<RC_9983883fbc26c5bf3e842f01355fd0c8> {
internal static readonly GlobalObjectKey IdForm = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*51_Tad9VjclXluEhtmqsdg");
internal static readonly GlobalObjectKey IdFormApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kYEjY7ry1fflX4dEX6xzBA");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENForm;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFormApprovalLevel;


public BitArray OptimizedAttributes;

public RC_9983883fbc26c5bf3e842f01355fd0c8() {
OptimizedAttributes = null;
ssENForm = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFormApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENForm.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFormApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENForm.OptimizedAttributes = value[0];
    ssENFormApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENForm.OptimizedAttributes;
    all[1] = ssENFormApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENForm.Read( r, ref index);
ssENFormApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_9983883fbc26c5bf3e842f01355fd0c8 r) {
this = r;
}


public static bool operator == (RC_9983883fbc26c5bf3e842f01355fd0c8 a, RC_9983883fbc26c5bf3e842f01355fd0c8 b) {
if (a.ssENForm != b.ssENForm) return false;
if (a.ssENFormApprovalLevel != b.ssENFormApprovalLevel) return false;
return true;
}

public static bool operator != (RC_9983883fbc26c5bf3e842f01355fd0c8 a, RC_9983883fbc26c5bf3e842f01355fd0c8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9983883fbc26c5bf3e842f01355fd0c8)) return false;
return (this == (RC_9983883fbc26c5bf3e842f01355fd0c8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENForm.GetHashCode()
 ^ ssENFormApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENForm.RecursiveReset();
ssENFormApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENForm.InternalRecursiveSave();
ssENFormApprovalLevel.InternalRecursiveSave();
}


public RC_9983883fbc26c5bf3e842f01355fd0c8 Duplicate() {
RC_9983883fbc26c5bf3e842f01355fd0c8 t;
t.ssENForm = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENForm.Duplicate();
t.ssENFormApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFormApprovalLevel.Duplicate();
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
if (head == "form") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Form")) variable.Value = ssENForm; else variable.Optimized = true;
variable.SetFieldName("form");
} else if (head == "formapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FormApprovalLevel")) variable.Value = ssENFormApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("formapprovallevel");
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
if (key == IdForm) {
return ssENForm;
}
if (key == IdFormApprovalLevel) {
return ssENFormApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdForm.Key.AsGuid) {
return ssENForm;
}
if (attributeKey == IdFormApprovalLevel.Key.AsGuid) {
return ssENFormApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENForm.FillFromOther((IRecord) other.AttributeGet(IdForm));
ssENFormApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFormApprovalLevel));
}
} // RC_9983883fbc26c5bf3e842f01355fd0c8
/// <summary>
/// RecordList type <code>FormFormApprovalLevelRecordList</code> that represents a record list of
///  <code>Folio, FolioApprovalLevel</code>
/// </summary>
public partial class RL_d88c6e81b1a4f5ae764d81477575511b : GenericRecordList<RC_9983883fbc26c5bf3e842f01355fd0c8>, IEnumerable, IEnumerator {

protected override RC_9983883fbc26c5bf3e842f01355fd0c8 GetElementDefaultValue() {
return new RC_9983883fbc26c5bf3e842f01355fd0c8();
}

public T[] ToArray<T>(Func<RC_9983883fbc26c5bf3e842f01355fd0c8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d88c6e81b1a4f5ae764d81477575511b recordList, Func<RC_9983883fbc26c5bf3e842f01355fd0c8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d88c6e81b1a4f5ae764d81477575511b(RC_9983883fbc26c5bf3e842f01355fd0c8[] array) {
  RL_d88c6e81b1a4f5ae764d81477575511b result = new RL_d88c6e81b1a4f5ae764d81477575511b();
result.InnerFromArray(array);
    return result;
}

public static RL_d88c6e81b1a4f5ae764d81477575511b ToList<T>(T[] array, Func <T, RC_9983883fbc26c5bf3e842f01355fd0c8> converter) {
  RL_d88c6e81b1a4f5ae764d81477575511b result = new RL_d88c6e81b1a4f5ae764d81477575511b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d88c6e81b1a4f5ae764d81477575511b FromRestList<T>(RestList<T> restList, Func <T, RC_9983883fbc26c5bf3e842f01355fd0c8> converter) {
  RL_d88c6e81b1a4f5ae764d81477575511b result = new RL_d88c6e81b1a4f5ae764d81477575511b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d88c6e81b1a4f5ae764d81477575511b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9983883fbc26c5bf3e842f01355fd0c8> NewList() {
return new RL_d88c6e81b1a4f5ae764d81477575511b();
}


} // RL_d88c6e81b1a4f5ae764d81477575511b
}

