namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ycStAWhZ5U+TmUJ4BZ3IWw)
///  <code>RC_d25c749e180f28d5d6211e73984f17d9</code> that represents <code>RetentionTypesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RetentionTypesRecord
public partial struct RC_d25c749e180f28d5d6211e73984f17d9 : ITypedRecord<RC_d25c749e180f28d5d6211e73984f17d9> {
internal static readonly GlobalObjectKey IdRetentionTypes = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nnRc0g8Y1SjWIR5zmE8X2Q");

public EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord ssENRetentionTypes;


public static implicit operator EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord( RC_d25c749e180f28d5d6211e73984f17d9 r) {
return r.ssENRetentionTypes;
}

public static implicit operator RC_d25c749e180f28d5d6211e73984f17d9 (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord r) {
RC_d25c749e180f28d5d6211e73984f17d9 res = new RC_d25c749e180f28d5d6211e73984f17d9 ();
res.ssENRetentionTypes = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRetentionTypes.ChangedAttributes = value;
}
get {
    return ssENRetentionTypes.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d25c749e180f28d5d6211e73984f17d9() {
OptimizedAttributes = null;
ssENRetentionTypes = new EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRetentionTypes.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRetentionTypes.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRetentionTypes.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRetentionTypes.Read( r, ref index);
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
public void ReadIM(RC_d25c749e180f28d5d6211e73984f17d9 r) {
this = r;
}


public static bool operator == (RC_d25c749e180f28d5d6211e73984f17d9 a, RC_d25c749e180f28d5d6211e73984f17d9 b) {
if (a.ssENRetentionTypes != b.ssENRetentionTypes) return false;
return true;
}

public static bool operator != (RC_d25c749e180f28d5d6211e73984f17d9 a, RC_d25c749e180f28d5d6211e73984f17d9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d25c749e180f28d5d6211e73984f17d9)) return false;
return (this == (RC_d25c749e180f28d5d6211e73984f17d9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRetentionTypes.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRetentionTypes.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRetentionTypes.InternalRecursiveSave();
}


public RC_d25c749e180f28d5d6211e73984f17d9 Duplicate() {
RC_d25c749e180f28d5d6211e73984f17d9 t;
t.ssENRetentionTypes = (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord)this.ssENRetentionTypes.Duplicate();
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
if (head == "retentiontypes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RetentionTypes")) variable.Value = ssENRetentionTypes; else variable.Optimized = true;
variable.SetFieldName("retentiontypes");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRetentionTypes.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRetentionTypes.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRetentionTypes) {
return ssENRetentionTypes;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRetentionTypes.Key.AsGuid) {
return ssENRetentionTypes;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRetentionTypes.FillFromOther((IRecord) other.AttributeGet(IdRetentionTypes));
}
} // RC_d25c749e180f28d5d6211e73984f17d9
/// <summary>
/// RecordList type <code>RetentionTypesRecordList</code> that represents a record list of
///  <code>RetentionTypes</code>
/// </summary>
public partial class RL_f9fe172e986346e2c0b7c749705a1940 : GenericRecordList<RC_d25c749e180f28d5d6211e73984f17d9>, IEnumerable, IEnumerator {

protected override RC_d25c749e180f28d5d6211e73984f17d9 GetElementDefaultValue() {
return new RC_d25c749e180f28d5d6211e73984f17d9();
}

public T[] ToArray<T>(Func<RC_d25c749e180f28d5d6211e73984f17d9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f9fe172e986346e2c0b7c749705a1940 recordList, Func<RC_d25c749e180f28d5d6211e73984f17d9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f9fe172e986346e2c0b7c749705a1940(RC_d25c749e180f28d5d6211e73984f17d9[] array) {
  RL_f9fe172e986346e2c0b7c749705a1940 result = new RL_f9fe172e986346e2c0b7c749705a1940();
result.InnerFromArray(array);
    return result;
}

public static RL_f9fe172e986346e2c0b7c749705a1940 ToList<T>(T[] array, Func <T, RC_d25c749e180f28d5d6211e73984f17d9> converter) {
  RL_f9fe172e986346e2c0b7c749705a1940 result = new RL_f9fe172e986346e2c0b7c749705a1940();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f9fe172e986346e2c0b7c749705a1940 FromRestList<T>(RestList<T> restList, Func <T, RC_d25c749e180f28d5d6211e73984f17d9> converter) {
  RL_f9fe172e986346e2c0b7c749705a1940 result = new RL_f9fe172e986346e2c0b7c749705a1940();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f9fe172e986346e2c0b7c749705a1940() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d25c749e180f28d5d6211e73984f17d9> NewList() {
return new RL_f9fe172e986346e2c0b7c749705a1940();
}


} // RL_f9fe172e986346e2c0b7c749705a1940
}

