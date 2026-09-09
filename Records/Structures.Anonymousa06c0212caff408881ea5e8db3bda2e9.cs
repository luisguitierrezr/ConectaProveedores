namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EgJsoP_KiECB6l6Ns72i6Q)
///  <code>RC_c8d5cf7b74d96976f36c31131cf6e264</code> that represent
/// s <code>OrderDistributionConfigTelcelDirectionRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderDistributionConfigTelcelDirectionRegionRecord
public partial struct RC_c8d5cf7b74d96976f36c31131cf6e264 : ITypedRecord<RC_c8d5cf7b74d96976f36c31131cf6e264> {
internal static readonly GlobalObjectKey IdOrderDistributionConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2pvFn9tBCnTof5HxNdJIEQ");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ssENOrderDistributionConfig;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_c8d5cf7b74d96976f36c31131cf6e264() {
OptimizedAttributes = null;
ssENOrderDistributionConfig = new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord();
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(13,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderDistributionConfig.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderDistributionConfig.OptimizedAttributes = value[0];
    ssENTelcelDirection.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderDistributionConfig.OptimizedAttributes;
    all[1] = ssENTelcelDirection.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderDistributionConfig.Read( r, ref index);
ssENTelcelDirection.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_c8d5cf7b74d96976f36c31131cf6e264 r) {
this = r;
}


public static bool operator == (RC_c8d5cf7b74d96976f36c31131cf6e264 a, RC_c8d5cf7b74d96976f36c31131cf6e264 b) {
if (a.ssENOrderDistributionConfig != b.ssENOrderDistributionConfig) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_c8d5cf7b74d96976f36c31131cf6e264 a, RC_c8d5cf7b74d96976f36c31131cf6e264 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c8d5cf7b74d96976f36c31131cf6e264)) return false;
return (this == (RC_c8d5cf7b74d96976f36c31131cf6e264)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderDistributionConfig.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderDistributionConfig.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderDistributionConfig.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_c8d5cf7b74d96976f36c31131cf6e264 Duplicate() {
RC_c8d5cf7b74d96976f36c31131cf6e264 t;
t.ssENOrderDistributionConfig = (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord)this.ssENOrderDistributionConfig.Duplicate();
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "orderdistributionconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDistributionConfig")) variable.Value = ssENOrderDistributionConfig; else variable.Optimized = true;
variable.SetFieldName("orderdistributionconfig");
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdOrderDistributionConfig) {
return ssENOrderDistributionConfig;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderDistributionConfig.Key.AsGuid) {
return ssENOrderDistributionConfig;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderDistributionConfig.FillFromOther((IRecord) other.AttributeGet(IdOrderDistributionConfig));
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_c8d5cf7b74d96976f36c31131cf6e264
/// <summary>
/// RecordList type <code>OrderDistributionConfigTelcelDirectionRegionRecordList</code> that represents
///  a record list of <code>OrderDistributionConfig, TelcelDirection, Region</code>
/// </summary>
public partial class RL_f1511df7dc3042c2ebd8fe2fdc783908 : GenericRecordList<RC_c8d5cf7b74d96976f36c31131cf6e264>, IEnumerable, IEnumerator {

protected override RC_c8d5cf7b74d96976f36c31131cf6e264 GetElementDefaultValue() {
return new RC_c8d5cf7b74d96976f36c31131cf6e264();
}

public T[] ToArray<T>(Func<RC_c8d5cf7b74d96976f36c31131cf6e264, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f1511df7dc3042c2ebd8fe2fdc783908 recordList, Func<RC_c8d5cf7b74d96976f36c31131cf6e264, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f1511df7dc3042c2ebd8fe2fdc783908(RC_c8d5cf7b74d96976f36c31131cf6e264[] array) {
  RL_f1511df7dc3042c2ebd8fe2fdc783908 result = new RL_f1511df7dc3042c2ebd8fe2fdc783908();
result.InnerFromArray(array);
    return result;
}

public static RL_f1511df7dc3042c2ebd8fe2fdc783908 ToList<T>(T[] array, Func <T, RC_c8d5cf7b74d96976f36c31131cf6e264> converter) {
  RL_f1511df7dc3042c2ebd8fe2fdc783908 result = new RL_f1511df7dc3042c2ebd8fe2fdc783908();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f1511df7dc3042c2ebd8fe2fdc783908 FromRestList<T>(RestList<T> restList, Func <T, RC_c8d5cf7b74d96976f36c31131cf6e264> converter) {
  RL_f1511df7dc3042c2ebd8fe2fdc783908 result = new RL_f1511df7dc3042c2ebd8fe2fdc783908();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f1511df7dc3042c2ebd8fe2fdc783908() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(13,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c8d5cf7b74d96976f36c31131cf6e264> NewList() {
return new RL_f1511df7dc3042c2ebd8fe2fdc783908();
}


} // RL_f1511df7dc3042c2ebd8fe2fdc783908
}

