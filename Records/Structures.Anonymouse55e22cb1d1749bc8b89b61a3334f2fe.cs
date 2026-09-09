namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yyJe5RcdvEmLibYaMzTy_g)
///  <code>RC_a6482208c24ce2e6c9c6ba16e57b0185</code> that represents <code>DistributionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DistributionRecord
public partial struct RC_a6482208c24ce2e6c9c6ba16e57b0185 : ITypedRecord<RC_a6482208c24ce2e6c9c6ba16e57b0185> {
internal static readonly GlobalObjectKey IdDistribution = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CCJIpkzC5uLJxroW5XsBhQ");

public EN_88460e7eac2a65d244abb23fe44af0adEntityRecord ssENDistribution;


public static implicit operator EN_88460e7eac2a65d244abb23fe44af0adEntityRecord( RC_a6482208c24ce2e6c9c6ba16e57b0185 r) {
return r.ssENDistribution;
}

public static implicit operator RC_a6482208c24ce2e6c9c6ba16e57b0185 (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord r) {
RC_a6482208c24ce2e6c9c6ba16e57b0185 res = new RC_a6482208c24ce2e6c9c6ba16e57b0185 ();
res.ssENDistribution = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDistribution.ChangedAttributes = value;
}
get {
    return ssENDistribution.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a6482208c24ce2e6c9c6ba16e57b0185() {
OptimizedAttributes = null;
ssENDistribution = new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDistribution.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDistribution.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDistribution.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDistribution.Read( r, ref index);
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
public void ReadIM(RC_a6482208c24ce2e6c9c6ba16e57b0185 r) {
this = r;
}


public static bool operator == (RC_a6482208c24ce2e6c9c6ba16e57b0185 a, RC_a6482208c24ce2e6c9c6ba16e57b0185 b) {
if (a.ssENDistribution != b.ssENDistribution) return false;
return true;
}

public static bool operator != (RC_a6482208c24ce2e6c9c6ba16e57b0185 a, RC_a6482208c24ce2e6c9c6ba16e57b0185 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a6482208c24ce2e6c9c6ba16e57b0185)) return false;
return (this == (RC_a6482208c24ce2e6c9c6ba16e57b0185)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDistribution.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDistribution.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDistribution.InternalRecursiveSave();
}


public RC_a6482208c24ce2e6c9c6ba16e57b0185 Duplicate() {
RC_a6482208c24ce2e6c9c6ba16e57b0185 t;
t.ssENDistribution = (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord)this.ssENDistribution.Duplicate();
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
if (head == "distribution") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Distribution")) variable.Value = ssENDistribution; else variable.Optimized = true;
variable.SetFieldName("distribution");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDistribution.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDistribution.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDistribution) {
return ssENDistribution;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDistribution.Key.AsGuid) {
return ssENDistribution;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDistribution.FillFromOther((IRecord) other.AttributeGet(IdDistribution));
}
} // RC_a6482208c24ce2e6c9c6ba16e57b0185
/// <summary>
/// RecordList type <code>DistributionRecordList</code> that represents a record list of
///  <code>Distribution</code>
/// </summary>
public partial class RL_63e875add2b98c15e5030850edd3b2eb : GenericRecordList<RC_a6482208c24ce2e6c9c6ba16e57b0185>, IEnumerable, IEnumerator {

protected override RC_a6482208c24ce2e6c9c6ba16e57b0185 GetElementDefaultValue() {
return new RC_a6482208c24ce2e6c9c6ba16e57b0185();
}

public T[] ToArray<T>(Func<RC_a6482208c24ce2e6c9c6ba16e57b0185, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_63e875add2b98c15e5030850edd3b2eb recordList, Func<RC_a6482208c24ce2e6c9c6ba16e57b0185, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_63e875add2b98c15e5030850edd3b2eb(RC_a6482208c24ce2e6c9c6ba16e57b0185[] array) {
  RL_63e875add2b98c15e5030850edd3b2eb result = new RL_63e875add2b98c15e5030850edd3b2eb();
result.InnerFromArray(array);
    return result;
}

public static RL_63e875add2b98c15e5030850edd3b2eb ToList<T>(T[] array, Func <T, RC_a6482208c24ce2e6c9c6ba16e57b0185> converter) {
  RL_63e875add2b98c15e5030850edd3b2eb result = new RL_63e875add2b98c15e5030850edd3b2eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_63e875add2b98c15e5030850edd3b2eb FromRestList<T>(RestList<T> restList, Func <T, RC_a6482208c24ce2e6c9c6ba16e57b0185> converter) {
  RL_63e875add2b98c15e5030850edd3b2eb result = new RL_63e875add2b98c15e5030850edd3b2eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_63e875add2b98c15e5030850edd3b2eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a6482208c24ce2e6c9c6ba16e57b0185> NewList() {
return new RL_63e875add2b98c15e5030850edd3b2eb();
}


} // RL_63e875add2b98c15e5030850edd3b2eb
}

