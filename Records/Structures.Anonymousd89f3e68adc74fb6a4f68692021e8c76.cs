namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aD6f2Mettk+k9oaSAh6Mdg)
///  <code>RC_367437e31e499bf19d13607cb372e4f5</code> that represent
/// s <code>ManualsManualFileRecord</code> <p>Description: </p>
/// </summary>
// Name: ManualsManualFileRecord
public partial struct RC_367437e31e499bf19d13607cb372e4f5 : ITypedRecord<RC_367437e31e499bf19d13607cb372e4f5> {
internal static readonly GlobalObjectKey IdManuals = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SJWDWrbCYmcJ2tn7F5vHbA");
internal static readonly GlobalObjectKey IdManualFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jy4Eba9vFpylGv3F1lCS3Q");

public EN_f9557b941e05ea8155a182da4f23a896EntityRecord ssENManuals;

public EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord ssENManualFile;


public BitArray OptimizedAttributes;

public RC_367437e31e499bf19d13607cb372e4f5() {
OptimizedAttributes = null;
ssENManuals = new EN_f9557b941e05ea8155a182da4f23a896EntityRecord();
ssENManualFile = new EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(12,false);
    all[1] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENManuals.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENManualFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENManuals.OptimizedAttributes = value[0];
    ssENManualFile.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENManuals.OptimizedAttributes;
    all[1] = ssENManualFile.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENManuals.Read( r, ref index);
ssENManualFile.Read( r, ref index);
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
public void ReadIM(RC_367437e31e499bf19d13607cb372e4f5 r) {
this = r;
}


public static bool operator == (RC_367437e31e499bf19d13607cb372e4f5 a, RC_367437e31e499bf19d13607cb372e4f5 b) {
if (a.ssENManuals != b.ssENManuals) return false;
if (a.ssENManualFile != b.ssENManualFile) return false;
return true;
}

public static bool operator != (RC_367437e31e499bf19d13607cb372e4f5 a, RC_367437e31e499bf19d13607cb372e4f5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_367437e31e499bf19d13607cb372e4f5)) return false;
return (this == (RC_367437e31e499bf19d13607cb372e4f5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENManuals.GetHashCode()
 ^ ssENManualFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENManuals.RecursiveReset();
ssENManualFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENManuals.InternalRecursiveSave();
ssENManualFile.InternalRecursiveSave();
}


public RC_367437e31e499bf19d13607cb372e4f5 Duplicate() {
RC_367437e31e499bf19d13607cb372e4f5 t;
t.ssENManuals = (EN_f9557b941e05ea8155a182da4f23a896EntityRecord)this.ssENManuals.Duplicate();
t.ssENManualFile = (EN_d89d65949fc0664870ebc65ca42d2f63EntityRecord)this.ssENManualFile.Duplicate();
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
if (head == "manuals") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Manuals")) variable.Value = ssENManuals; else variable.Optimized = true;
variable.SetFieldName("manuals");
} else if (head == "manualfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManualFile")) variable.Value = ssENManualFile; else variable.Optimized = true;
variable.SetFieldName("manualfile");
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
if (key == IdManuals) {
return ssENManuals;
}
if (key == IdManualFile) {
return ssENManualFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdManuals.Key.AsGuid) {
return ssENManuals;
}
if (attributeKey == IdManualFile.Key.AsGuid) {
return ssENManualFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENManuals.FillFromOther((IRecord) other.AttributeGet(IdManuals));
ssENManualFile.FillFromOther((IRecord) other.AttributeGet(IdManualFile));
}
} // RC_367437e31e499bf19d13607cb372e4f5
/// <summary>
/// RecordList type <code>ManualsManualFileRecordList</code> that represents a record list of
///  <code>Manuals, ManualFile</code>
/// </summary>
public partial class RL_d2939f0caa78f2bcae0d5522f32cf37b : GenericRecordList<RC_367437e31e499bf19d13607cb372e4f5>, IEnumerable, IEnumerator {

protected override RC_367437e31e499bf19d13607cb372e4f5 GetElementDefaultValue() {
return new RC_367437e31e499bf19d13607cb372e4f5();
}

public T[] ToArray<T>(Func<RC_367437e31e499bf19d13607cb372e4f5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d2939f0caa78f2bcae0d5522f32cf37b recordList, Func<RC_367437e31e499bf19d13607cb372e4f5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d2939f0caa78f2bcae0d5522f32cf37b(RC_367437e31e499bf19d13607cb372e4f5[] array) {
  RL_d2939f0caa78f2bcae0d5522f32cf37b result = new RL_d2939f0caa78f2bcae0d5522f32cf37b();
result.InnerFromArray(array);
    return result;
}

public static RL_d2939f0caa78f2bcae0d5522f32cf37b ToList<T>(T[] array, Func <T, RC_367437e31e499bf19d13607cb372e4f5> converter) {
  RL_d2939f0caa78f2bcae0d5522f32cf37b result = new RL_d2939f0caa78f2bcae0d5522f32cf37b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d2939f0caa78f2bcae0d5522f32cf37b FromRestList<T>(RestList<T> restList, Func <T, RC_367437e31e499bf19d13607cb372e4f5> converter) {
  RL_d2939f0caa78f2bcae0d5522f32cf37b result = new RL_d2939f0caa78f2bcae0d5522f32cf37b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d2939f0caa78f2bcae0d5522f32cf37b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(12,false);
def[1] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_367437e31e499bf19d13607cb372e4f5> NewList() {
return new RL_d2939f0caa78f2bcae0d5522f32cf37b();
}


} // RL_d2939f0caa78f2bcae0d5522f32cf37b
}

